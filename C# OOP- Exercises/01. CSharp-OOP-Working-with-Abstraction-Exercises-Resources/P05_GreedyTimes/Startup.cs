using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Startup
    {
        static void Main(string[] args)
        {
            long capacityBag = long.Parse(Console.ReadLine());

            string[] safe = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            long gold = 0;
            long gem = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {

                DeterminingLoot(safe, i, out string name, out long piece, out string loot);

                if (loot == "")
                {
                    continue;
                }
                else if (capacityBag < bag.Values.Select(x => x.Values.Sum()).Sum() + piece)
                {
                    continue;
                }

                switch (loot)
                {
                    case "Gem":
                        if (!bag.ContainsKey(loot))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (piece > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[loot].Values.Sum() + piece > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(loot))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (piece > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[loot].Values.Sum() + piece > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                SummingUploot(bag, ref gold, ref gem, ref money, name, piece, loot);
            }

            Print(bag);
        }

        private static void Print(Dictionary<string, Dictionary<string, long>> bag)
        {
            foreach (var loot in bag)
            {
                Console.WriteLine($"<{loot.Key}> ${loot.Value.Values.Sum()}");

                foreach (var lootNeme in loot.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{lootNeme.Key} - {lootNeme.Value}");
                }
            }
        }

        private static void SummingUploot(Dictionary<string, Dictionary<string, long>> bag, ref long gold, ref long gem, ref long money, string name, long piece, string loot)
        {
            if (!bag.ContainsKey(loot))
            {
                bag[loot] = new Dictionary<string, long>();
            }

            if (!bag[loot].ContainsKey(name))
            {
                bag[loot][name] = 0;
            }

            bag[loot][name] += piece;

            if (loot == "Gold")
            {
                gold += piece;
            }
            else if (loot == "Gem")
            {
                gem += piece;
            }
            else if (loot == "Cash")
            {
                money += piece;
            }
        }

        private static void DeterminingLoot(string[] safe, int i, out string name, out long piece, out string loot)
        {
            name = safe[i];

            piece = long.Parse(safe[i + 1]);

            loot = string.Empty;

            if (name.Length == 3)
            {
                loot = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                loot = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                loot = "Gold";
            }
        }
    }
}