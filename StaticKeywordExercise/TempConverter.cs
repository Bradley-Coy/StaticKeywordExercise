using System;
namespace StaticKeywordExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            return (fTemp - 32) * 5 / 9;

        }


        public static double CelsiusToFahrenheit(double cTemp)
        {
            return (cTemp * 9) / 5 + 32;

        }
    }
}

