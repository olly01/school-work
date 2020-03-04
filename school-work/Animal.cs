﻿using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
     public class Animal
    {
        public String Name;
        public int Age;
        public Boolean Sex;
        public int Health;
        public string Species;
        protected List<string> _diet;

        public Animal(string name, int age, Boolean sex, int health) // constructor
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Health = health;
        }

        public bool Eat(string Food)
        {
            if (_diet.Contains(Food))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Animal reproduce(string species, string baby_name, bool baby_sex)
        {
            if (species == "Toucan")
            {
                Toucan child = new Toucan(baby_name, 0, baby_sex, 10);
                return (child);
            }
            else if (species == "Penguin")
            {
                Penguin child = new Penguin(baby_name, 0, baby_sex, 10);
                return (child);
            }
            else if (species == "Pelican")
            {
                Pelican child = new Pelican(baby_name, 0, baby_sex, 10);
                return (child);
            }
            else if (species == "Ostrich")
            {
                Ostrich child = new Ostrich(baby_name, 0, baby_sex, 10);
                return (child);
            }
            else
            {
                Console.WriteLine("No mutant babies");
                return (null);
            }
        }

        public void medicine()
        {

        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age.ToString() + 1} Health: {Health}";
        }
    }
}