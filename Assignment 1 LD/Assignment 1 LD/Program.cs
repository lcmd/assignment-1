using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_LD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Enter an Integer");
            int integer = int.Parse(Console.ReadLine());
            if (integer < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (integer >= 10)
               {
                Console.WriteLine("This number is big enough");
               }

            //Question 2
            float[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[1]);

            //Question 3
            float[] numbers3 = { 1, 2, 3, 4, 5 };
            int counter;
            for (counter = 0; counter < numbers3.Length; counter++)
            {
                Console.WriteLine(numbers3[counter]);
            }

            //Question 4
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Only one?");
                    break;
                case 100:
                    Console.WriteLine("100? That's a lot!");
                    break;
                default:
                    Console.WriteLine("Input not recognized");
                    break;
            }


        }
    }
}
