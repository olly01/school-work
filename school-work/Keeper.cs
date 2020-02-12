using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Keeper : Staff
    {
        public List<Animal> _AnimalList;
        public Keeper(String name, List<Animal> AnimalList) : base(name)
        {
            this._AnimalList = AnimalList;
        }
    }
}