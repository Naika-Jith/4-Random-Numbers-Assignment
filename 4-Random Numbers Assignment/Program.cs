using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4_Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Random Numbers Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Random Numbers Assignment!");
            Console.WriteLine();
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Part 1 : Random Integers

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Part 1: Random Integers");
            Console.WriteLine();

            int minimum;
            int maximum;

            Console.Write("Please enter the minimum value: ");
            minimum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the maximum value: ");
            maximum = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(random.Next(minimum, maximum + 1) + " ");
            }
            Console.WriteLine();



            //Part 2 : Random Decimal Numbers

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Part 2: Random Decimal Numbers");
            Console.WriteLine();

            int dice1;
            int dice2;
            int sum;

            Random random1 = new Random();

            Console.WriteLine("Rolling the dice...");
            Thread.Sleep(1000);
            Console.WriteLine();
            dice1 = random1.Next(1, 7);
            Console.WriteLine("First dice: " + dice1);
            Thread.Sleep(1000);
            dice2 = random1.Next(1, 7);
            Console.WriteLine("Second dice: " + dice2);
            Console.WriteLine();
            sum = dice1 + dice2;
            Console.WriteLine("The sum of the two dice is: " + sum);

            //Part 3 : Random Decimal Numbers

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Part 3: Random Decimal Numbers");
            Console.WriteLine();

            double minimum2;
            double maximum2;
            double decimal1;
            double decimal2;
            double decimal3;
            int decimalPlaces;

            Console.Write("Enter the minimum value: ");
            minimum2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the maximum value: ");
            maximum2 = Convert.ToDouble(Console.ReadLine());

            if (maximum2 < minimum2)
            {
                Console.WriteLine("The maximum can't be less than the minimum.");
                decimalPlaces = Convert.ToInt32(Console.ReadLine());
            }


            else
            {
                Console.WriteLine();
                Console.Write("How many decimal places would you like? ");
                decimalPlaces = Convert.ToInt32(Console.ReadLine());

                Random random3 = new Random();

                // NextDouble gives a random number from 0 to 1,
                //then we adjust it to fit between our minimum and maximum
                decimal1 = minimum2 + (random3.NextDouble() * (maximum2 - minimum2));
                decimal2 = minimum2 + (random3.NextDouble() * (maximum2 - minimum2));
                decimal3 = minimum2 + (random3.NextDouble() * (maximum2 - minimum2));

                decimal1 = Math.Round(decimal1, decimalPlaces);
                decimal2 = Math.Round(decimal2, decimalPlaces);
                decimal3 = Math.Round(decimal3, decimalPlaces);

                Console.WriteLine();
                Console.WriteLine(decimal1 + " " + decimal2 + " " + decimal3);
            }






        }
    }
}
