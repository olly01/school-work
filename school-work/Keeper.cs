using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Keeper : Staff
    {
        public List<Animal> _AnimalList;
        public Keeper(String name) : base(name)
        {
            _AnimalList = new List<Animal>();
            Role = "Keeper";
        }

        public void Feed()
        {
            string food;
            foreach (Animal animal in _AnimalList)
            {
                Console.WriteLine("What should " + _name + "feed " + animal.Name);
                food = Console.ReadLine();
                if (animal.Eat(food))
                {
                    Console.WriteLine(_name + " has fed " + animal.Name);
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