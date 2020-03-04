using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Pelican : Bird
    {
        public Pelican(string name, int age, bool sex, int health) : base(name, age, sex, health)
        {
            _diet = new List<string>() { "Amphibians", "Turtles", "Crustaceans", "Insects" };
            Species = "Pelican";
        }
    }
}