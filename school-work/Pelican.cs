using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Pelican : Bird
    {
        public Pelican()
        {
            _diet = new List<string>() { "Amphibians", "Turtles", "Crustaceans", "Insects" };
        }
    }
}