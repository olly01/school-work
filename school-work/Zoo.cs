using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Zoo
    {
        public List<Animal> animals = new List<Animal>();
        private List<Staff> _staff = new List<Staff>();
        public List<Enclosure> enclosures = new List<Enclosure>();
        static Dictionary<string, int> _foodStore = new Dictionary<string, int>();

        public List<Staff> Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }

        public void createFoodStore()
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

        public void Eat(string food)
        {
            if (_foodStore.ContainsKey(food) == true)
            {
                _foodStore[food]--;
            }
        }

        public void Restock()
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

        public Animal AddAnimal(string species, string name, int age, GenderType gender, int health)
        {
            Animal animal = null;
            switch (species)
            {
                case "Toucan":
                    animal = new Toucan(name, age, gender, health);
                    break;
                case "Ostrich":
                    animal = new Ostrich(name, age, gender, health);
                    break;
                case "Penguin":
                    animal = new Penguin(name, age, gender, health);
                    break;
                case "Pelican":
                    animal = new Pelican(name, age, gender, health);
                    break;
                default:
                    throw new ArgumentException("Invalid Species.");
            }
            animals.Add(animal);
            return animal;
        }

        public void AddStaff(string role, string name)
        {
            if (role == "Keeper")
            {
                Keeper NewKeeper = new Keeper(name, this);
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
                    Console.WriteLine(animal);
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

        public void AddEnclosure(string contents, int size, int WaterLevel, int temperature, bool enclosed, int PlantLife, bool shelter, string name, int capacity)
        {
            Enclosure NewEnclosure = new Enclosure(name, contents,size,capacity,WaterLevel, temperature, shelter, PlantLife);
            enclosures.Add(NewEnclosure);
        }

    }
}

//when feeding animals, if you try to feed them something they dont eat, they wont eat it and  it wont ask you to try again