using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Bird : Animal
    {
        protected bool _canFly;

        public Bird(string name, int age, Boolean sex, int health) : base( name,  age,  sex, health)
        {
            
        }
        public bool CanFly
        {
            get
            {
                return _canFly;
            }
            set
            {
                _canFly = value;
            }
        }
    }
}