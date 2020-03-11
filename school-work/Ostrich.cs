using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Ostrich : Bird
    {
        public Ostrich(string name, int age, GenderType gender, int health) : base(name, age, gender, health)
        {
            _diet = new List<string>() { "roots", "leaves", "insects", "seeds" };
            Species = "Ostrich";
        }
    }
}