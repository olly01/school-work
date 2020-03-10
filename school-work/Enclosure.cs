using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Enclosure
    {
        private List<Animal> animals = new List<Animal>();
        private string enclosureName;
        public string _contents;
        private int size;
        private int capacity;
        private int waterLevel;
        private int temp;
        private bool shelter;
        private int plantLife;

        public Enclosure(string _enclosurename, string _contents, int _size, int _capcity, int _waterlevel, int _temp, bool _shelter, int _plantLife)
        {
           

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
    }
}
