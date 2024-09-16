using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string answer;
            int angle, minutes, speed;
            double cost = 2;
            
            while (done == false)
            {
                Console.WriteLine("Which feature would you like to access? \n(C for compass, P for parking garage, H for hurricane, D for done)");
                answer = Console.ReadLine().ToLower();
                Console.Clear();

                if (answer == "c")
                {
                    Console.WriteLine("Give me any angle and I'll tell you what direction you are going");
                    while (Int32.TryParse(Console.ReadLine(), out angle) == false)
                    {
                        Console.WriteLine("That's not what I'm looking for");
                    }

                    while (angle > 360) { angle -= 360; }

                    switch (angle)
                    {
                        case int n when (n <= 30):
                            Console.WriteLine("You are facing North");
                            break;
                        case int n when (n >= 30 && n <= 60):
                            Console.WriteLine("You are facing North-East");
                            break;
                        case int n when (n >= 60 && n <= 120):
                            Console.WriteLine("You are facing East");
                            break;
                        case int n when (n >= 120 && n <= 150):
                            Console.WriteLine("You are facing South-East");
                            break;
                        case int n when (n >= 150 && n <= 210):
                            Console.WriteLine("You are facing South");
                            break;
                        case int n when (n >= 210 && n <= 240):
                            Console.WriteLine("You are facing South-West");
                            break;
                        case int n when (n >= 240 && n <= 300):
                            Console.WriteLine("You are facing West");
                            break;
                        case int n when (n >= 300 && n <= 330):
                            Console.WriteLine("You are facing North-West");
                            break;
                        case int n when (n <= 330):
                            Console.WriteLine("You are facing North");
                            break;
                    }

                    Console.WriteLine("\n\n");
                }

                else if (answer == "p")
                {
                    Console.WriteLine("How many minutes were you parked?");
                    while (Int32.TryParse(Console.ReadLine(), out minutes) == false && minutes > 0)
                    {
                        Console.WriteLine("That's not what I'm looking for");
                    }

                    while (minutes >= 0 && cost < 20)
                    {
                        cost += 2;
                        minutes -= 60;
                    }

                    Console.WriteLine($"You owe {cost.ToString("C")}");
                    Console.WriteLine("\n\n");
                    cost = 2;
                }

                else if (answer == "h")
                {
                    Console.WriteLine("How fast were the winds in km/h?");
                    while (Int32.TryParse(Console.ReadLine(), out speed) == false)
                    {
                        Console.WriteLine("That's not what I'm looking for");
                    }

                    switch (speed)
                    {
                        case int n when (n <= 118):
                            Console.WriteLine("That's not even a hurricane...");
                            break;
                        case int n when (n >= 119 && n <= 153):
                            Console.WriteLine("Sounds like a category 1 hurricane");
                            break;
                        case int n when (n >= 154 && n <= 177):
                            Console.WriteLine("Sounds like a category 2 hurricane");
                            break;
                        case int n when (n >= 178 && n <= 209):
                            Console.WriteLine("Sounds like a category 3 hurricane");
                            break;
                        case int n when (n >= 210 && n <= 249):
                            Console.WriteLine("Sounds like a category 4 hurricane");
                            break;
                        case int n when (n > 250):
                            Console.WriteLine("WOAH! Sounds like a category 5 hurricane!");
                            break;
                    }
                    Console.WriteLine("\n\n");
                }

                else if (answer == "d")
                {
                    done = true;
                }

                else
                {
                    Console.WriteLine("I don't recognise that command");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }
    }
}
