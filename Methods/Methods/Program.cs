using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // methods are a way to group together code to make it easier to read
            // also called functions

            Greet_user();
            add(3000, 12);
            add(1, 2, 3);
            Console.WriteLine(multiply(3, 7));
            int result = multiply(35,67);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Greet_user()
        {
            Console.WriteLine("Hello");
        }

        static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + "+" + num2 + "=" + num1 + num2);
        }

        static void add(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + "=" + num1 + num2 +num3);
        }

        static int multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

    }
}
