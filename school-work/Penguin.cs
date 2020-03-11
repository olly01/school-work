using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Penguin : Bird
    {
        public Penguin(string name, int age, GenderType gender, int health) : base(name, age, gender, health)
        {
            _diet = new List<string>() { "fish", "squid", "krill" };
            Species = "Penguin";
        }
    }
}