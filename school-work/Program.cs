using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin();

            foreach (String food in penguin.Diet)
            {
                Console.WriteLine(food);
            }
            Console.ReadLine();
        }
    }
}