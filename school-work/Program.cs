﻿using System;
using System.Collections.Generic;

namespace school_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int bob = 10;

            List<Animal> animallist = new List<Animal>();

            Keeper fred = new Keeper("fred", animallist);


            Console.WriteLine(fred.Name);

            Animal animal = new Animal("a", 1, true, 1);



            Console.WriteLine(bob);
            Console.ReadLine();

        }
    }
}
