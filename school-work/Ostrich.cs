using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Ostrich : Bird
    {
        public Ostrich()
        {
            _diet = new List<string>() { "Roots", "Leaves", "Insects", "Seeds" };
        }
    }
}