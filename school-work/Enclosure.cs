using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Enclosure
    {
        private List<Animal> animals = new List<Animal>();
        public string enclosureName;
        public string contents;
        private int size;
        private int capacity;
        private int waterLevel;
        private int temp;
        private bool shelter;
        private int plantLife;

        public Enclosure(string _enclosureName, string _contents, int _size, int _capacity, int _waterLevel, int _temp, bool _shelter, int _plantLife)
        {
            this.enclosureName = _enclosureName;
            this.contents = _contents;
            this.size= _size;
            this.capacity = _capacity;
            this.waterLevel = _waterLevel;
            this.temp = _temp;
            this.shelter = _shelter;
            this.plantLife = _plantLife;
        }

        public void addAnimals(Animal _newAnimal )
        {
            if (animals.Count < capacity)
            {
                animals.Add(_newAnimal);
                
            }
            else if (animals.Count >= capacity)
            {
                Console.WriteLine("Theres not enough space, please try another enclosure.");
                
            
            }

        }

        public void removeAnimals(int _numberInList)
        {
            animals.RemoveAt(_numberInList);
        }

        public void Print()
        {

            Console.WriteLine("Enclosure: " + enclosureName);
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Animal Capacity: " + capacity);
            Console.WriteLine("Animals in the Enclosure:");
            Console.WriteLine("Space Left: " + (size - animals.Count));
            Console.WriteLine("Water Level: " + waterLevel);
            Console.WriteLine("Temperature: " + temp);
            Console.WriteLine("Shelter: " + shelter);
            Console.WriteLine("Amount of Plant Life: " + plantLife);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
