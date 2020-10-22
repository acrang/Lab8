using System;
using System.IO.Pipes;

namespace Lab8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Information Aggregator!");
            Console.WriteLine();
            Console.WriteLine("=================================================");
            bool continueInput = true;
            while (continueInput)
            {

                // Initializing variables and arrays

                string userInput;
                string again;
                int answer = 0;
                int result = 0;
                const int indexOffset = 1;
                string[] firstNames = { "Peter", "Paul", "Mary" };
                string[] lastNames = { "Brown", "Arnold", "Gilfried" };
                string[] foods = { "Bratwurst", "Lentils", "Grilled Asparagus" };
                string[] hometown = { "Rochester", "Mt. Pleasant", "Marquette" };
                int[] ages = { 29, 41, 56 };

                Console.WriteLine();
                Console.WriteLine("Which student would you like to learn more about?");
                Console.WriteLine();
                Console.WriteLine($"1) {firstNames[1 - indexOffset]} {lastNames[1 - indexOffset]}\t 2) {firstNames[2 - indexOffset]} {lastNames[2 - indexOffset]}\t 3) {firstNames[3 - indexOffset]} {lastNames[3 - indexOffset]}");


                bool validInput = true;
                while (validInput)
                {

                    userInput = Console.ReadLine();
                    try
                    {
                        result = Int32.Parse(userInput);
                        Console.WriteLine();
                        Console.WriteLine($"Student {result} is {firstNames[result - indexOffset]} {lastNames[result - indexOffset]}.");
                        Console.WriteLine($"What would you like to know about {firstNames[result - indexOffset]}? Enter one of the following: (Age / Hometown / Favorite food)");
                        Console.WriteLine();
                        validInput = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry. You entered an invalid character. Please make sure you are entering a number.");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid entry. Please use the number corresponding to the student you would like to learn about.");
                    }
                }

                bool preferenceCheck = true;
                while (preferenceCheck)
                {
                    string preference = Console.ReadLine();
                    Console.WriteLine();
                    if (preference == "Age")
                    {
                        Console.WriteLine($"{firstNames[result - indexOffset]} is {ages[result]} years old.");
                        preferenceCheck = false;
                    }
                    else if (preference == "Hometown")
                    {
                        Console.WriteLine($"{firstNames[result - indexOffset]} is originally from {hometown[result - indexOffset]}.");
                        preferenceCheck = false;
                    }
                    else if (preference == "Favorite food")
                    {
                        Console.WriteLine($"{firstNames[result - indexOffset]}'s favorite food is {foods[result - indexOffset]}.");
                        preferenceCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter one of the following: (Age / Hometown / Favorite food)");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Would you like to know about any other students? (y/n)");
                Console.WriteLine();

                bool response = true;
                while (response)
                {
                    again = Console.ReadLine();

                    if (again == "n")
                    {
                        continueInput = false;
                        Console.WriteLine();
                        Console.WriteLine("Thank you. Please remember all information is confidential."); //goodbye message
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        break;
                    }
                    else if (again == "y")
                    {
                        response = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Error. Please enter either 'y' or 'n'."); //yes/no checker error message
                    }
                }
            }
        }
    }
}
