using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_and_Loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lost games count:");
            int lostGamesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Headset price:");
            double headsetPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Mouse price:");
            double mousePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Keyboard price:");
            double keyboardPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Display price");
            double displayPrice = double.Parse(Console.ReadLine());

            int br = 0;
            int notBr = 0;

            double[] totalExpenses = new double[lostGamesCount];

            for (int i = lostGamesCount; i > 0; i--)
            {

                if (i % 2 == 0)
                {
                    totalExpenses[i - 1] = totalExpenses[i - 1] + headsetPrice;
                }

                if (i % 3 == 0)
                {
                    totalExpenses[i - 1] = totalExpenses[i - 1] + mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    br++;
                    totalExpenses[i - 1] = totalExpenses[i - 1] + keyboardPrice;
                }
                if (br % 2 == 0 && br != notBr)
                {
                    totalExpenses[i - 1] = totalExpenses[i - 1] + displayPrice;
                }

                notBr = br;
            }

            Console.WriteLine("Rage expenses: {0} lv.", totalExpenses.Sum());
            Console.ReadLine();
        }
    }
}
