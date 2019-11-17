using _08MilitaryElite.Contracts;
using _08MilitaryElite.Enums;
using _08MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace _08MilitaryElite.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private Dictionary<int,ISolduer> soldiers;

        public CommandInterpreter()
        {
            this.soldiers = new Dictionary<int,ISolduer>();
        }

        public string Read(string[] args)
        {
            string soldierType = args[0];
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];

            ISolduer soldier = null;

            if (soldierType == "Private")
            {
                decimal salary = decimal.Parse(args[4]);

                soldier = new Private(id, firstName, lastName, salary);
            }
            else if (soldierType == "LieutenantGeneral")
            {
                decimal salary = decimal.Parse(args[4]);
                var privates  = new Dictionary<int, IPrivate>();

                for (int i = 5; i < args.Length; i++)
                {
                    int soldierId = int.Parse(args[i]);

                    var currentSoldier =(IPrivate) soldiers[soldierId];

                    privates.Add(soldierId, currentSoldier);
                }

                soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
            }
            else if (soldierType == "Engineer")
            {
                decimal salary = decimal.Parse(args[4]);

                bool isValidCorps = Enum.TryParse(args[5], out Corps corps);

                if (!isValidCorps)
                {
                    throw new Exception("");
                }

                ICollection<IRepair> repairs = new List<IRepair>();

                for (int i = 6; i < args.Length; i+=2)
                {
                    int hours = int.Parse(args[i + 1]);

                    var currentName = args[i];

                    var repair = new Repair(currentName, hours);

                    repairs.Add(repair);
                }

                soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
            }
            else if (soldierType == "Commando")
            {
                decimal salary = decimal.Parse(args[4]);

                bool isValidMission = Enum.TryParse(args[5], out Corps corps);

                if (!isValidMission)
                {
                    throw new Exception("");
                }

                ICollection<IMission> missions = new List<IMission>();

                for (int i = 6; i < args.Length; i+=2)
                {
                    string missionName = args[i];

                    string missionState = args[i + 1];

                    bool isValidState = Enum.TryParse(missionState, out State result);

                    if (!isValidState)
                    {
                        continue;
                    }

                    var mission = new Mission(missionName, result);

                    missions.Add(mission);
                }

                soldier = new Comando(id, firstName, lastName, salary, corps, missions);
            }
            else if (soldierType == "Spy")
            {
                int codeNumber = int.Parse(args[4]);

                soldier = new Spy(id, firstName, lastName, codeNumber);
            }

            this.soldiers.Add(id, soldier);

            return soldier.ToString();
        }
    }
}
