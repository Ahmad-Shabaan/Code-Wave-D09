using System.ComponentModel;

namespace Code_Wave_D09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string Value = "ab45";
            //int ConvertedValue1 = Convert.ToInt32(Value); // this will throw FormatException
            //int convertedValue2 = int.Parse(Value);// this will throw FormatException too
            // you should use tryparse
            bool IsConvertedValue3 = int.TryParse(Value , out int result);
            if (IsConvertedValue3) 
                Console.WriteLine("converted value is:" + result);
            else
                Console.WriteLine("Invalid value");



            //2 - Write C# program that Extract a substring from a given string.
            string Value2 = "Ahmed Shabaan";
            string LastName = Value2.Split(" ")[1];
            Console.WriteLine($"Substring(Last name) is: {LastName}");


            //3 - Write C# program that take two string variables and print them as one variable
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your second name: ");
            string LastName2 = Console.ReadLine();
            string name = FirstName + " " + LastName2;
            Console.WriteLine($"Your name is {name}");


            //4.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a
            //variable then display the
            //result.
            //Note :
            //a.that below 10 degrees is "Just Cold"
            //b.above 30 degrees is "Just Hot"
            //c.anything else is "Just Good

            Console.Write("Please enter the temperature of today: ");
            bool IsTemp = float.TryParse(Console.ReadLine(), out float temp);
            if (IsTemp)
            {
                string status = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
                Console.WriteLine($"The tmperature of today is {status}");
                
            }
            else
            {
                Console.WriteLine("Invalid Temperature");
            }
            
        }
    }
}
