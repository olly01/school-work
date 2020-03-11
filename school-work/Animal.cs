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
        public Animal(string name, int age, GenderType gender, int health) // constructor sets values
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Health = health;
            _diet = new List<string>();


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
            if (species == "Toucan")
            {
                Toucan child = new Toucan(baby_name, 0, baby_gender, 10);
                return (child);
            }
            else if (species == "Penguin")
            {
                Penguin child = new Penguin(baby_name, 0, baby_gender, 10);
                return (child);
            }
            else if (species == "Pelican")
            {
                Pelican child = new Pelican(baby_name, 0, baby_gender, 10);
                return (child);
            }
            else if (species == "Ostrich")
            {
                Ostrich child = new Ostrich(baby_name, 0, baby_gender, 10);
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
            return $"Name: {Name} Age: {Age} Health: {Health} Gender: {Gender}" ;
        }
    }
}