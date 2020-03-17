using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    public enum GenderType { Female, Male}
     public class Animal
    {
     
        public String Name { get;}
        public int Age{ get; set; }

        public GenderType Gender;
        public int Health;
        public string Species;

        public List<string> _diet { get; protected set; }
        static int instance = 0;
        public int IDnum { get; set; }
        public Animal(string name, int age, GenderType gender, int health) // constructor sets values
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Health = health;
            _diet = new List<string>();
            instance = instance + 1;
            IDnum = instance;


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

        public Animal reproduce(string species, string baby_name, GenderType baby_gender)
        {
            Animal child = null;

            switch (species)
            {
                case "Toucan":
                    child = new Toucan(baby_name, 0, baby_gender, 10);
                    break;
                case "Penguin":
                    child = new Penguin(baby_name, 0, baby_gender, 10);
                    break;
                case "Pelican":
                    child = new Pelican(baby_name, 0, baby_gender, 10);
                    break;
                case "Ostrich":
                    child = new Ostrich(baby_name, 0, baby_gender, 10);
                    break;
                default:
                    throw new ArgumentException("Invalid Species.");
            }
            return (child);
        }

        public void medicine()
        {

        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Health: {Health} Gender: {Gender} ID Number: {IDnum}" ;
        }
    }
}