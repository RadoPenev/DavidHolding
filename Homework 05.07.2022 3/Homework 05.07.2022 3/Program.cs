using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05._07._2022_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int totalSteps = 0;
            bool didReachTheeGoal = false;

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    didReachTheeGoal = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (didReachTheeGoal)
            {
                int stepsOver = totalSteps - 10000;

                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int aditionalSteps = int.Parse(Console.ReadLine());
                totalSteps += aditionalSteps;

                if (totalSteps >= 10000)
                {
                    int stepsOver = totalSteps - 10000;

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOver} steps over the goal!");
                }
                else
                {
                    int stepsToGoal = 10000 - totalSteps;
                    Console.WriteLine($"{stepsToGoal} more steps to reach goal.");
                }
            }
                Console.WriteLine();
        }
    }
}
