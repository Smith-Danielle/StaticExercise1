using System;

namespace StaticExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double converted = (TempConverter.FahrenheitToCelsius(100));
            Console.WriteLine($"The conversion from Fahrenheit to Celsius is {converted}");

            Console.WriteLine("Please enter a temperature in Celsius to convert to Fahrenheit:");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            TempConverter.CelsiusToFahrenheit(userNumber);
            
        }
    }
}
