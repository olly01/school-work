using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes new zoo
            Zoo zoo = new Zoo();
            SetUp(zoo);
            Menu(zoo);
        }

        private static string Menu(Zoo zoo)
        {
            string choice = "banana";
            string name;
            string species;
            int age;
            int health;
            string role;
            GenderType gender;
            // while loop means than you can keep doing stuff to the zoo till you want to leave
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

                // the switch case statement lets the user choose a procedure and passes the appropriate information into them
                switch (choice)
                {
                    case "1":
                        foreach (Enclosure enclosure in zoo.enclosures)
                        {
                            Console.WriteLine(enclosure.enclosureName);
                            enclosure.ShowAnimals();
                            Console.WriteLine();
                        }
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
                        Console.WriteLine("What is the animals gender: 1 for female, 2 for male");
                        gender = (GenderType)(Convert.ToInt32((Console.ReadLine())) - 1);
                        Console.WriteLine("Out of 10, how healthy is the animal");
                        health = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            Animal animal = zoo.AddAnimal(species, name, age, gender, health);

                            foreach (Enclosure enclosure in zoo.enclosures)
                            {
                                if (animal.Species == enclosure.contents)
                                {
                                    enclosure.addAnimals(animal);
                                }
                            }

                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
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

            return choice;
        }

        private static void SetUp(Zoo zoo)
        {
            Random GetRandom = new Random();
            int DetermineGender;

            //19 - 22 puts enclosures into the zoo. parameters go (contents, size, waterlevel, temperature, fully enclosed, plantlife)
            zoo.AddEnclosure("Toucan", 2, 1, 23, true, 3, true, "Toucan Enclosure 1", 10);
            zoo.AddEnclosure("Penguin", 2, 3, -3, false, 0, true, "Penguin Enclosure 1", 10);
            zoo.AddEnclosure("Pelican", 2, 2, 20, false, 2, true, "Pelican Enclosure 1", 10);
            zoo.AddEnclosure("Ostrich", 3, 1, 30, false, 1, true, "Ostrich Enclosure 1", 10);

            // Lines 25 - 79 create animals, they do this by doing the contents of a for loop 4 times, and each time creates a new animal of the same type, this for loop is repeated for each animal species available
            for (int i = 1; i <= 4; i++)
            {
                DetermineGender = GetRandom.Next(0, 2);

                zoo.AddAnimal("Pelican", "Pelican" + i, GetRandom.Next(0, 20), (GenderType)DetermineGender, GetRandom.Next(1, 10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineGender = GetRandom.Next(0, 2);

                zoo.AddAnimal("Penguin", "Penguin" + i, GetRandom.Next(0, 25), (GenderType)DetermineGender, GetRandom.Next(1, 10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineGender = GetRandom.Next(0, 2);

                zoo.AddAnimal("Toucan", "Toucan" + i, GetRandom.Next(0, 20), (GenderType)DetermineGender, GetRandom.Next(1, 10));
            }

            for (int i = 1; i <= 4; i++)
            {
                DetermineGender = GetRandom.Next(0, 2);

                zoo.AddAnimal("Ostrich", "Ostrich" + i, GetRandom.Next(0, 50), (GenderType)DetermineGender, GetRandom.Next(1, 10));
            }

            // lines 82-91 puts animals in enclosures by comparing the name of the species to the contents of the enclosure and only putting an animal in if its  species matches the contents of the enclosure
            foreach (Animal animal in zoo.animals)
            {
                foreach (Enclosure enclosure in zoo.enclosures)
                {
                    if (enclosure.contents == animal.Species)
                    {
                        enclosure.addAnimals(animal);
                    }
                }
            }

            //94 - 99 add staff members



            for (int i = 1; i <= 4; i++)
            {
                zoo.AddStaff("Keeper", "Keeper" + i);
            }

            zoo.AddStaff("Vet", "Vet1");

            int x = 0;

            //104 - 114 gives each keeper their animals, at the moment, this is just the first 4 unasigned animals in the list
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
        }
    }
    }