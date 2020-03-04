using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Enclosure
    {
        public List<Animal> animals = new List<Animal>();
        public string _contents;
        public int _size;
        public int _WaterLevel;
        public int _Temperature;
        public bool _enclosed;
        public int _PlantLife;

        public Enclosure(string contents, int size, int WaterLevel, int temperature, bool enclosed, int PlantLife)
        {
            this._contents = contents;
            this._size = size;
            this._WaterLevel = WaterLevel;
            this._Temperature = temperature;
            this._enclosed = enclosed;
            this._PlantLife = PlantLife;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
