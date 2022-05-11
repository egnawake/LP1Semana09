using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("Joe", 4),
                new Player("Steve", 10)
            };

            string op = "";
            while (op != "quit")
            {
                Console.Write("> ");
                op = Console.ReadLine();

                if (op == "add")
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter score: ");
                    int score = int.Parse(Console.ReadLine());

                    players.Add(new Player(name, score));

                    Console.WriteLine($"Added {name} with {score} points");
                }
                else if (op == "list")
                {
                    ListPlayers(players);
                }
                else if (op == "listscore")
                {
                    Console.Write("Enter min score: ");
                    int score = int.Parse(Console.ReadLine());

                    IEnumerable<Player> list = GetPlayersWithScoreGreaterThan(score, players);

                    ListPlayers(list);
                }
                else if (op == "quit")
                {
                    Console.WriteLine("Bye!");
                }
                else
                {
                    Console.WriteLine("Unrecognized command");
                }
            }
        }

        private static IEnumerable<Player> GetPlayersWithScoreGreaterThan(
            int score,
            IEnumerable<Player> players)
        {
            List<Player> l = new List<Player>();
            foreach (Player p in players)
            {
                if (p.Score > score)
                {
                    l.Add(p);
                }
            }
            return l;
        }

        private static void ListPlayers(IEnumerable<Player> players)
        {
            foreach (Player p in players)
            {
                Console.WriteLine($"{p.Name}, {p.Score} points");
            }
        }
    }
}
