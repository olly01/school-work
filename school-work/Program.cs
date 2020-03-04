using System;
using System.Collections.Generic;
using System.Text;

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


            Penguin penguin = new Penguin("Penguin", 1, true, 3);
            Console.WriteLine(penguin);

            Console.WriteLine(penguin.Eat("Fish"));

            Console.ReadLine();

            Console.WriteLine("A new ostrich chick has just hatched");
            Console.WriteLine("What would you like to name it");
            string name = Console.ReadLine();
            Animal chick = animal.reproduce("Ostrich", name, true);
            animallist.Add(chick);

            foreach (Animal item in animallist)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}