using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
        public static class Logger
        {
            // Static method to log messages to the console with a timestamp
            public static void LogMessage(string message)
            {
                Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
            }
     
           public static void Application()
            {
                // Log a message when the application starts
                Logger.LogMessage("Application started.");

                // Simulate some operations
                Console.WriteLine("Performing some tasks...");

                // Log a message after tasks are completed
                Logger.LogMessage("Tasks completed successfully.");

                // Simulate more operations
                Console.WriteLine("Shutting down...");

                // Final log message before ending the application
                Logger.LogMessage("Application ended.");
            }
        }
    }

