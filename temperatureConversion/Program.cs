using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            temperatureConversion _tempConversion = new temperatureConversion();
            int itemp = -1, numb;
            Console.WriteLine("Assignment 2");
            while (itemp < 0)
            {
                Console.WriteLine("Enter the temperature");
                if (int.TryParse(Console.ReadLine(), out numb))
                {
                    if (numb > 0)
                    {
                        itemp = numb;
                    }
                }

            }
            _tempConversion = new temperatureConversion(itemp);

            Console.Clear();
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Celsius to Kelvin");
            Console.WriteLine("3. Convert Fahrenheit to Celsius");
            Console.WriteLine("4. Convert Fahrenheit to Kelvin");
            Console.WriteLine("5. Convert Kelvin to Celsius");
            Console.WriteLine("6. Convert Kelvin to Fahrenheit");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Choose one option");

            if (int.TryParse(Console.ReadLine(), out numb))
            {
                if (numb == 1)
                {
                    Console.WriteLine("Converted value: " + _tempConversion.ConvertCelciusToFahrenheit().ToString());
                }
                else if (numb == 2)
                {
                    Console.WriteLine("Convert value: " + _tempConversion.ConvertCelciusToKelvin().ToString());
                }
                else if (numb == 3)
                {
                    Console.WriteLine("Convert value: " + _tempConversion.ConvertKelvinToFahrenheit().ToString());
                }
                else if (numb == 4)
                {
                    Console.WriteLine("Convert value: " + _tempConversion.ConvertKelvinToCelsius().ToString());
                }
                else if (numb == 5)
                {
                    Console.WriteLine("Convert value: " + _tempConversion.ConvertFahrenheitToKelvin().ToString());
                }
                else if (numb == 6)
                {
                    Console.WriteLine("Convert value: " + _tempConversion.ConvertFahrenheitToCelsius().ToString());
                }
                else
                {
                    return;
                }
                Console.WriteLine("Press any Key to Continue");
                Console.ReadLine();
            }
        }
    }
}
