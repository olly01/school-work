﻿using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Toucan : Bird
    {
        public Toucan(string name, int age, bool sex, int health) : base(name, age, sex, health)
        {
            _diet.Add("Fruit");
            _diet.Add("Insects");
            Species = "Toucan";
        }
    }
}