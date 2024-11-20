using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q5A3
    {
        public partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // Second part of the partial class with methods
        public partial class Person
        {
            public void PrintFullName()
            {
                Console.WriteLine($"Full Name: {FirstName} {LastName}");
            }
        }
           public static void Count()
            {
                // Create a new Person object
                Person person = new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Call the PrintFullName method
                person.PrintFullName();
            }
        }
    }

