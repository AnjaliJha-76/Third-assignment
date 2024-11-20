using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q8A3
    {

        public abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            protected Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Abstract method
            public abstract void MakeSound();

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }

            public void Fetch()
            {
                Console.WriteLine($"{Name} is fetching the ball!");
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }

            public void Scratch()
            {
                Console.WriteLine($"{Name} is scratching the furniture!");
            }
        }

      
    }
}