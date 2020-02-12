using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Bird : Animal
    {
        protected bool _canFly;

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