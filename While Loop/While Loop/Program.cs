using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1; //could also be written i+=1
            }


            // Example, seeing how many tries it takes to roll a six on a d6

            Random random = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = random.Next(1, 7);
                Console.WriteLine("Rolled " + attempt);
                numberOfAttempts += 1;
            }

            Console.WriteLine("Total Attempts " + numberOfAttempts);

            // Do While Loops. Use when sure will iterate at least once, checks after action, not before

            do
            {
                Console.WriteLine(i);
                i += 1;
            } while (i<=20);


            Console.ReadLine();
        }
    }
}
