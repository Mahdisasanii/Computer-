using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double avg = (num1 + num2) / 2;
            if (avg > num1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();

        }
    }
}
