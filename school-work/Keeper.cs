using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Keeper : Staff
    {
        public List<Animal> _AnimalList;
        public Keeper(String name, List<Animal> AnimalList) : base(name)
        {
            this._AnimalList = AnimalList;
        }

        public void Feed(string food)
        {
            foreach (Animal animal in _AnimalList)
            {
                animal.Eat(food);
                Console.WriteLine(_name + " has fed " + animal.Name);
            }
        }

    }
}