using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse_Of_A_Right_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                double side1, side2;

                Console.Write("Enter Side 1 (Negative to Quit): ");
                side1 = Convert.ToDouble(Console.ReadLine());

                if (side1 < 0) { break; }

                Console.Write("Enter Side 2 (Negative to Quit): ");
                side2 = Convert.ToDouble(Console.ReadLine());

                if (side2 < 0) { break; }

                double result = CalculateHyp(side1, side2);

                Console.WriteLine("Hypotenuse is " + result + ".");
            }

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        static double CalculateHyp(double side1, double side2)
        {
            double hyp = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            hyp = Math.Sqrt(hyp);
            return hyp;
        }
    }
}
