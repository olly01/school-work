using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Staff
    {
        public string _name; //Private Field
        public string Role;
        static int instance = 0;
        public int IDNum;

        public string Name //property
        {
            get { return _name; }
            set {
                _name = value; }
        }

        public Staff(string name) // constructor
        {
            this.Name = name;
            instance = instance + 1;
            IDNum = instance;
        }

    }
}
