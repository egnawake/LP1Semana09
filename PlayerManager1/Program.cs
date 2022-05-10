﻿using System;
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
    }
}