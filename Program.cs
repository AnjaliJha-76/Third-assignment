using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThirdAssignment.Q8A3;

namespace ThirdAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1A3.Salary();
            //Q2A3.Integer();
            //Q3A3.Number();
            // Logger.Application();
            //Q5A3.Count();
            //Q6A3.Calculate();
            //Q7A3.Area();
            //Animal.Count();
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);

            dog.DisplayInfo();
            dog.MakeSound();
            dog.Fetch();

            cat.DisplayInfo();
            cat.MakeSound();
            cat.Scratch();
            Console.ReadLine();



            /*            Q9A3.Integer();
            */
        }
    }
}
