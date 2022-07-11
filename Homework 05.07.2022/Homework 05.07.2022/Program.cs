using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your budget:");
            double budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the season:");
            string season = Console.ReadLine();
            Console.WriteLine("The number of fishermen");
            int fishermen = int.Parse(Console.ReadLine());
            double boatPrice = 0;
            double extraCash = 0;
            if (season == "spring")
            {
                boatPrice = 3000;
                if (fishermen <= 6)
                {
                    boatPrice = boatPrice - (boatPrice * 0.1);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    boatPrice = boatPrice - (boatPrice * 0.15);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 12)
                {
                    boatPrice = boatPrice - (boatPrice * 0.25);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }

            }




            else if (season == "summer"||season == "autumn")
            {
                boatPrice = 4200;
                if (fishermen <= 6)
                {
                    boatPrice = boatPrice - (boatPrice * 0.1);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    boatPrice = boatPrice - (boatPrice * 0.15);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 12)
                {
                    boatPrice = boatPrice - (boatPrice * 0.25);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }

            }




            else if (season == "winter")
            {
                boatPrice = 2600;
                if (fishermen <= 6)
                {
                    boatPrice = boatPrice - (boatPrice * 0.1);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 7 && fishermen <= 11)
                {
                    boatPrice = boatPrice - (boatPrice * 0.15);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }
                else if (fishermen >= 12)
                {
                    boatPrice = boatPrice - (boatPrice * 0.25);
                    if (boatPrice > budget)
                    {
                        extraCash = boatPrice - budget;
                        Console.WriteLine("You don't have enough money. You need {0} extra cash.", extraCash);
                    }
                    else
                    {
                        extraCash = budget - boatPrice;
                        Console.WriteLine("Yes you have enough money. You have {0} extra cash left", extraCash);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
