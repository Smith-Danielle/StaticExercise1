using System;
namespace StaticExercise1
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {

            double celsiusConvert = (fahrenheit - 32) * (5.0 / 9.0);
            
            return celsiusConvert;
        }
        public static void CelsiusToFahrenheit(double celsius)
        {
            
            double fahrenheitConvert = (celsius * (9.0 / 5.0)) + 32;

            Console.WriteLine($"The Fahrenheit is {fahrenheitConvert}");
        }
    }
}
