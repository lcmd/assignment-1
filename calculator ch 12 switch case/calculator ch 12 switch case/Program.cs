using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_ch_12_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1; //assigning all variables
            double number2; //assigning variables
            double result; //assigning variables
            
            Console.WriteLine("Enter a number, then hit enter:"); //enter the first number 
            //display first number
            number1 = double.Parse(Console.ReadLine()); 
            //enter second number
            Console.WriteLine("Enter another number, then hit enter");
            //display second number
            number2 = double.Parse(Console.ReadLine());
             
            Console.WriteLine("enter operator"); //ask user to enter the operator

            string operand = Console.ReadLine(); //assigning string to store operator

            switch (operand) //switch the operator
            {
                case "+": // case 1 if user enter operator "+"
                    result = number1 + number2;
                    break;

                case "-": // case 2 if user enter operatior "-"
                    result = number1 - number2;
                    break;

                case "*":  // case 3 if user enter operator "*"
                    result = number1 * number2;
                    break;

                case "/":  // case 4 if user enter operator "/"
                    result = number1 / number2;
                    break;

                case "%":  // case 5 if user enter operator "%"
                    result = number1 % number2;
                    break;

                case "^": // case 6 if user enter power
                    result = Math.Pow(number1, number2);
                    break;

                default:  // this is default if any user enter invalid operator it will show invalid operator
                    result = (0);
                    break;
            }
            Console.WriteLine(number1.ToString() + " " + operand + " " + number2.ToString() + " = " + result.ToString());
            Console.ReadLine();
            Console.ReadKey();
        }
    } 
}
