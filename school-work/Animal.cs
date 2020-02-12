using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Animal
    {
        private String Name;
        private Int64 Age;
        private Boolean Sex;
        private Int64 Health;

        protected List<string> _diet;

        public List<string> Diet 
        {
            get
            {
                return _diet;
            }
        }
    }
}