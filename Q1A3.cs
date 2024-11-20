using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q1A3
    {

        class Employee
        {
            // Properties
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }

            // Constructor
            public Employee(string name, int age, decimal salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }

            // Method to display employee details
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Salary: {Salary:C}");
            }
        }

             public static void Salary()
            {
                // Create an employee object
                Employee emp = new Employee("John Doe", 30, 50000.50m);

                // Display employee details
                emp.DisplayEmployeeDetails();
            }

        }
    }

