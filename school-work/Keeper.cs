using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Keeper : Staff
    {
        public List<Animal> _AnimalList;
        private Zoo zoo;

        public Keeper(String name, Zoo zoo) : base(name)
        {
            _AnimalList = new List<Animal>();
            Role = "Keeper";
            this.zoo = zoo;
            
        }

        public void Feed()
        {
            string food;
            foreach (Animal animal in _AnimalList)
            {
                Console.WriteLine("\n{0} eats:\n", animal.Name);

                foreach (string foodItem in animal._diet) //FIX THISSSSSS
                {
                    Console.WriteLine(foodItem);
                }

                Console.WriteLine("\nWhat should " + _name + "feed " + animal.Name);
                food = (Console.ReadLine()).ToLower();

                if (animal.Eat(food))
                {
                    Console.WriteLine(_name + " has fed " + animal.Name);
                    zoo.Eat(food);
                }
                else
                {
                    Console.WriteLine(animal.Name + " doesn't eat that");
                }
            }
        }

        public void AssignAnimal(Animal animal)
        {
            _AnimalList.Add(animal);
        }
    }
}