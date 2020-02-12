using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Toucan : Bird
    {
        public Toucan()
        {
            _diet = new List<string>() { "Fruit", "Insects" };
        }
    }
}