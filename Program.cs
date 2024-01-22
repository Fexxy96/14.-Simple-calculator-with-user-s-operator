using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Simple_calculator_with_user_s_opeerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter an number ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter an Operator");
            string op = Console.ReadLine();

            Console.WriteLine(" Enter second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            { Console.WriteLine(num1 / num2);
            }
            else
            { Console.WriteLine(" not an operator");

                Console.Read();
                    }

        }
    }
}
