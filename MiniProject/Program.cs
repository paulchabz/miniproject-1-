using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Application 
            // Ask the user for the first name 
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            // Ask the user for their age
            Console.Write("What is your age? ");
            string ageText = Console.ReadLine();

            // Convert the ageText to age
            bool isValidAge = int.TryParse(ageText, out int age);
            // if age is not valid 
            if (isValidAge == false)
            {
                Console.WriteLine("That is not a valid age please input a number.");
                Console.ReadLine(); // pauses the app 
                return; // closes out the main method {application}
            }

            // check for first name 
            string formattedName = "";
            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                // name = professor
                formattedName = $"Professor {firstName}";
            }
            else
            {
                formattedName = firstName;
            }

            // check for age less than 21 
            if (age < 21)
            {
                Console.WriteLine($"I recommend you wait {21 - age} years before you start this class {formattedName} ");
            }
            else
            {
                Console.WriteLine($"Welcome to the class {formattedName} :) ");
            }

            Console.ReadLine();
        }
    }
}
