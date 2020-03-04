using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Program
    {
        static void Main(string[] args)
        {

            Zoo zoo = new Zoo();
            Random GetRandom = new Random();
            bool sex;
            int DetermineSex;

            zoo.AddEnclosure("Toucan", 2, 1, 23, true, 3);
            zoo.AddEnclosure("Penguin", 2, 3, -3, false, 0);
            zoo.AddEnclosure("Pelican", 2, 2, 20, false, 2);
            zoo.AddEnclosure("Ostrich", 3, 1, 30, false, 1);

            for (int i= 1 ; i<=4; i++)
            {
                DetermineSex = GetRandom.Next(1, 3);
                if (DetermineSex == 1)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
                zoo.AddAnimal("Pelican", "Pelican" + i, GetRandom.Next(0,20), sex, GetRandom.Next(0,10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineSex = GetRandom.Next(1, 3);
                if (DetermineSex == 1)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
                zoo.AddAnimal("Penguin", "Penguin" + i, GetRandom.Next(0, 25), sex, GetRandom.Next(0, 10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineSex = GetRandom.Next(1, 3);
                if (DetermineSex == 1)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
                zoo.AddAnimal("Toucan", "Toucan" + i, GetRandom.Next(0, 20), sex, GetRandom.Next(0, 10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineSex = GetRandom.Next(1, 3);
                if (DetermineSex == 1)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
                zoo.AddAnimal("Ostrich", "Ostrich" + i, GetRandom.Next(0, 50), sex, GetRandom.Next(0, 10));
            }

            foreach (Animal animal in zoo.animals)
            {
                foreach (Enclosure enclosure in zoo.enclosures)
                {
                    if (enclosure._contents == animal.Species)
                    {
                        enclosure.AddAnimal(animal);
                    }
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                zoo.AddStaff("Keeper", "Keeper" + i);
            }

            zoo.AddStaff("Vet", "Vet1");

            int x = 0;

            foreach (Staff staff in zoo.Staff)
            {
                if (staff is Keeper keeper)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        keeper.AssignAnimal(zoo.animals[x]);
                        x = x + 1;
                    }
                }
            }

            string choice = "banana";
            string name;
            string species;
            int age;
            int health;
            string role;

            while (choice != "exit")
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do");
                Console.WriteLine("1) View List of animals");
                Console.WriteLine("2) View List of Staff");
                Console.WriteLine("3) Feed the animals");
                Console.WriteLine("4) Add an animal");
                Console.WriteLine("5) Hire a staff member");
                Console.WriteLine("Press anything else to exit");
                Console.WriteLine();

                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        zoo.ShowAnimals();
                        break;
                    case "2":
                        zoo.ShowStaff();
                        break;
                    case "3":

                        foreach (Staff staff in zoo.Staff)
                        {
                            if (staff is Keeper keeper)
                            {
                                keeper.Feed();
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("What is the animals name");
                        name = Console.ReadLine();
                        Console.WriteLine("What is the animals species");
                        species = Console.ReadLine();
                        Console.WriteLine("What is the animals age");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the animals sex: true for male, false for female");
                        sex = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Out of 10, how healthy is the animal");
                        health = Convert.ToInt32(Console.ReadLine());
                        zoo.AddAnimal(species, name, age, sex, health);

                        foreach (Enclosure enclosure in zoo.enclosures)
                        {
                            if (zoo.animals[zoo.animals.Count].Species == enclosure._contents)
                            {
                                enclosure.AddAnimal(zoo.animals[zoo.animals.Count]);
                            }
                        }

                        break;
                    case "5":
                        Console.WriteLine("What is the new employee's name");
                        name = Console.ReadLine();
                        Console.WriteLine("What is the new employee's role");
                        role = Console.ReadLine();
                        zoo.AddStaff(role, name);
                        break;
                    default:
                        choice = "exit";
                        break;
                }
                Console.ReadLine();
            }
            }

        }
    }
