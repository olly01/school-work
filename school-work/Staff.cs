﻿using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Staff
    {
        private string _name; //Private Field


        public string Name //property
        {
            get { return _name; }
            set {
                _name = value; }
        }

        public Staff(string name) // constructor
        {
            this.Name = name;
        }

    }
}
