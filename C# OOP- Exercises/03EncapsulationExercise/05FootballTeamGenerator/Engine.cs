using System;
using System.Collections.Generic;

namespace _05FootballTeamGenerator
{
    public class Engine
    {
        public static void Start()
        {
            string[] command = Console.ReadLine().Split(";");

            var teams = new Dictionary<string, Team>();

            while (command[0] != "END")
            {
                string teamName = command[1];

                if (command[0] == "Team" && !teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Team(teamName));
                }
                else if (command[0] == "Add")
                {
                    string playerName = command[2];

                    if (!teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");

                        command = Console.ReadLine().Split(";");

                        continue;
                    }

                    if (!teams[teamName].Players.ContainsKey(playerName))
                    {
                        int endurance = int.Parse(command[3]);
                        int sprint = int.Parse(command[4]);
                        int dribble = int.Parse(command[5]);
                        int passing = int.Parse(command[6]);
                        int shooting = int.Parse(command[7]);

                        var plaeyer = new Player(playerName, endurance
                                                , sprint, dribble
                                                , passing, shooting);

                        if (plaeyer.Endurance < 0
                            || plaeyer.Sprint < 0
                            || plaeyer.Dribble < 0
                            || plaeyer.Passing < 0
                            || plaeyer.Shooting < 0)
                        {
                            command = Console.ReadLine().Split(";");

                            continue;
                        }

                        teams[teamName].Players.Add(playerName, plaeyer);
                    }
                }
                else if (command[0] == "Remove" && teams.ContainsKey(teamName))
                {
                    string playerName = command[2];

                    if (teams[teamName].Players.ContainsKey(playerName))
                    {
                        teams[teamName].Players.Remove(playerName);
                    }
                    else
                    {
                        Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                    }
                }
                else if (command[0] == "Rating")
                {
                    if (!teams.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{teamName} - {teams[teamName].GetRatingTeam()}");
                    }
                }

                command = Console.ReadLine().Split(";");
            }
        }
    }
}
