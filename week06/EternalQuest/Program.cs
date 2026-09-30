using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        string choice = "";

        // Creativity:
        // Added a level system where every 1000 points increases the level.

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine($"Level: {(score / 1000) + 1}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                Console.Write("Which type of goal? ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    goals.Add(new SimpleGoal(name, description, points));
                }
                else if (type == 2)
                {
                    goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == 3)
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus));
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(score);

                    foreach (Goal goal in goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }

                Console.WriteLine("Goals saved.");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Loading not fully implemented yet.");
            }
            else if (choice == "5")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
                }

                Console.Write("Which goal did you accomplish? ");
                int goalNumber = int.Parse(Console.ReadLine());

                int earned = goals[goalNumber - 1].RecordEvent();

                score += earned;

                Console.WriteLine($"You earned {earned} points!");
            }
        }
    }
}