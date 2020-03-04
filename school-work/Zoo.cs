using System;
using System.Collections.Generic;
using System.Text;

namespace school_work
{
    class Zoo
    {

        //private List<Enclosures> enclosures = new List<Enclosures>(); 
        private List<Animal> _animals = new List<Animal>();
        private List<Staff> _staff = new List<Staff>();
        static Dictionary<string, int> _foodStore = new Dictionary<string, int>();

        public List<Staff> Staff
        {
            get { return _staff = new List<Staff>(); }
            set { _staff = value; }
        }

        public static void createFoodStore()
        {
            _foodStore.Add("fish", 10);
            _foodStore.Add("fruit", 10);
            _foodStore.Add("insects", 10);
            _foodStore.Add("squid", 10);
            _foodStore.Add("krill", 10);
            _foodStore.Add("amphibians", 10);
            _foodStore.Add("turtles", 10);
            _foodStore.Add("crustaceans", 10);
            _foodStore.Add("roots", 10);
            _foodStore.Add("leaves", 10);
            _foodStore.Add("seeds", 10);
        }

        public static void Eat(string food)
        {
            if (_foodStore.ContainsKey(food) == true)
            {
                Console.WriteLine("{0} : {1}", food, _foodStore[food]);
                _foodStore[food]--;
                Console.WriteLine("{0} : {1}\n", food, _foodStore[food]);
            }
            else
            {
                Console.WriteLine("We do not stock that food\n");
            }
        }

        public static void Restock()
        {
            int restock = 0;
            string food = "";

            Console.WriteLine("Current Stock\n");


            foreach (KeyValuePair<string, int> foodItem in _foodStore)
            {
                Console.WriteLine("{0} : {1}", foodItem.Key, foodItem.Value);
            }

            Console.Write("\nWhich item would you like to restock? ");
            food = Console.ReadLine();

            if (_foodStore.ContainsKey(food) == true)
            {
                Console.WriteLine("\nHow much {0} do you wish to increase the stock by? ", food);
                restock = Convert.ToInt32(Console.ReadLine());
                _foodStore[food] += restock;
            }
            else
            {
                Console.WriteLine("We do not stock that food\n");
            }
        }
    }
}