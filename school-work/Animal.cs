﻿using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
     public class Animal
    {
        public String Name;
        private int Age;
        private Boolean Sex;
        private int Health;

        public Animal(string name, int age, Boolean sex, int health) // constructor
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Health = health;
        }
        }

        public bool Eat(string Food)
        {
            foreach (string item in _diet)
            {
                if (Food == item)
                {
                    return (true);
                }
            }
            return (false);
        }
    }
}