﻿using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Ostrich : Bird
    {
        public Ostrich(string name, int age, bool sex, int health) : base(name, age, sex, health)
        {
            _diet = new List<string>() { "Roots", "Leaves", "Insects", "Seeds" };
            Species = "Ostrich";
        }
    }
}