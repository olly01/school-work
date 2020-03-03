using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Code
{
    class Program
    {
        class Animal
        {
            public int count = 0;

            public string Name= "";
            private int Age = 0;
            private Boolean Sex;

           public void Print()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
                Console.WriteLine(Sex);

            }

            class Dog : Animal
            {
                public int spotCount;
                public void Bark()
                {
                    Console.WriteLine("Ruff!");
                }

            }

            class Cat : Animal
            {
                public int cuteness;
                public void Meow()
                {
                    Console.WriteLine("Meow!");
                }
            }
                
            public static void Main(string[] args) // this is a method called "Main". It is called when the program starts.

            {
                Cat one = new Cat();
                one.Name = "Mia";
                one.Age = 2;
                one.Sex = true;
                one.cuteness = 3;
                one.Print();
                one.Meow();

                Console.ReadLine();


            }

            

        }
        
    }

}

