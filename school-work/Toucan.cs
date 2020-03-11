using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Toucan : Bird
    {
        public Toucan(string name, int age, GenderType gender, int health) : base(name, age, gender, health)
        {
            _diet.Add("fruit");
            _diet.Add("insects");
            Species = "Toucan";
        }
    }
}