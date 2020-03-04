using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Zoo
    {

        //private List<Enclosures> enclosures = new List<Enclosures>(); 
        public List<Animal> animals = new List<Animal>();
        private List<Staff> _staff = new List<Staff>();
        static Dictionary<string, int> _foodStore = new Dictionary<string, int>();

        public List<Staff> Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }

        public static void createFoodStore()
        {
            _foodStore.Add("fish", 10);
            _foodStore.Add("fruit", 10);
            _foodStore.Add("insects", 10);
            _foodStore.Add("squid", 10);
            _foodStore.Add("krill", 10);
            _foodStore.Add("amphibians", 10);
            _foodStore.Add("turtles", 10);
            _foodStore.Add("crustaceans", 10);
            _foodStore.Add("roots", 10);
            _foodStore.Add("leaves", 10);
            _foodStore.Add("seeds", 10);
        }

        public static void Eat(string food)
        {
            if (_foodStore.ContainsKey(food) == true)
            {
                Console.WriteLine("{0} : {1}", food, _foodStore[food]);
                _foodStore[food]--;
                Console.WriteLine("{0} : {1}\n", food, _foodStore[food]);
            }
            else
            {
                Console.WriteLine("We do not stock that food\n");
            }
        }

        public static void Restock()
        {
            int restock = 0;
            string food = "";
            Console.Write("\nWhich item would you like to restock? ");
            food = Console.ReadLine();

            if (_foodStore.ContainsKey(food) == true)
            {
                Console.WriteLine("\nHow much {0} do you wish to increase the stock by? ", food);
                restock = Convert.ToInt32(Console.ReadLine());
                _foodStore[food] += restock;
            }
            else
            {
                Console.WriteLine("We do not stock that food\n");
            }
        }

        public void AddAnimal(string species, string name, int age, bool sex, int health)
        {
            if (species == "Toucan")
            {
                Toucan NewToucan = new Toucan(name, age, sex, health);
                animals.Add(NewToucan);
            }
            else if(species == "Ostrich")
            {
                Ostrich NewOstrich = new Ostrich(name, age, sex, health);
                animals.Add(NewOstrich);
            }
            else if (species == "Penguin")
            {
                Penguin NewPenguin = new Penguin(name, age, sex, health);
                animals.Add(NewPenguin);
            }
            else if (species == "Pelican")
            {
                Pelican NewPelican = new Pelican(name, age, sex, health);
                animals.Add(NewPelican);
            }
            else
            {
                Console.WriteLine("Invalid Species");
            }

            
        }
        public void AddStaff(string role, string name)
        {
            if (role == "Keeper")
            {
                Keeper NewKeeper = new Keeper(name);
                _staff.Add(NewKeeper);
            }
            else if (role == "Vet")
            {
                Vet NewVet = new Vet(name);
                _staff.Add(NewVet);
            }
            else
            {
                Console.WriteLine("Job not availiable");
            }
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine("Species: " + animal.Species);
                Console.WriteLine(("Age: " + animal.Age)) ;
                Console.WriteLine("Health: " + animal.Health);
                if (animal.Sex == true)
                {
                    Console.WriteLine("Sex: Male");
                }
                else
                {
                    Console.WriteLine("Sex: Female");
                }
                Console.WriteLine();
            }
        }

        public void ShowStaff()
        {
            foreach (Staff member in _staff)
            {
                Console.WriteLine(member._name + ": " + member.Role);
                Console.WriteLine();
            }
        }


            
    }
}