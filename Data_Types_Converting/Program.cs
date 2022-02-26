using System;

namespace Data_Types_Converting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // most of covertings are like this two examples
            /* you should convert your data type to the output that you want,
               for example if you want to have math you should convert your data type to int or float */

            // int to string
            int age = 18;

            // This code will throw error 
            // string unconvertedAge = age;
            string convertedAge = age.ToString();


            // string to int
            int ageInput;
            string firstNumber, secondNumber;

            Console.Write("\n" + "Enter your age please: ");
            ageInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Nice you're " + ageInput + "years old!" + "\n" + "-----------------------------------------");

            Console.WriteLine("Please enter the first number:");
            firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            secondNumber = Console.ReadLine();

            // if we don't use convert string input for calculation
            Console.WriteLine("numbers together: " + firstNumber + secondNumber);

            // here we should use parenthesis to give math priority 
            Console.WriteLine("the sum of both is: " + (int.Parse(firstNumber) + int.Parse(secondNumber)));

            // you can also replace int.Parse() with Convert.ToInt32() but int.Parse is better to use

        }
    }
}
