using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q6A3
    {
        public partial class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int HoursWorked { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal Bonus { get; set; }
        }

        // Second part of the partial class with salary calculation methods
        public partial class Employee
        {
            // Method to calculate base salary
            public decimal CalculateBaseSalary()
            {
                return HoursWorked * HourlyRate;
            }

            // Method to calculate total salary including bonus
            public decimal CalculateTotalSalary()
            {
                return CalculateBaseSalary() + Bonus;
            }

            // Method to print salary details
            public void PrintSalaryDetails()
            {
                Console.WriteLine($"Employee: {FirstName} {LastName}");
                Console.WriteLine($"Base Salary: {CalculateBaseSalary():C}");
                Console.WriteLine($"Bonus: {Bonus:C}");
                Console.WriteLine($"Total Salary: {CalculateTotalSalary():C}");
            }
        }
            public static void Calculate()
            {
                // Create a new Employee object
                Employee employee = new Employee
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    HoursWorked = 160, // Example: 160 hours worked in a month
                    HourlyRate = 25.0m, // Example: $25 per hour
                    Bonus = 500.0m // Example: $500 bonus
                };

                // Print employee salary details
                employee.PrintSalaryDetails();
            }
        }
    }

