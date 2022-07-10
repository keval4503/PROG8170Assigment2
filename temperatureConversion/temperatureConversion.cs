using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureConversion
{
    public class temperatureConversion
    {
        private double temperatureValue;

        public temperatureConversion()
        {
            temperatureValue = 1;
        }

        public temperatureConversion(int _storedNum)
        {
            temperatureValue = _storedNum;
        }

        public double ConvertCelciusToFahrenheit()
        {
            double tempResult = (temperatureValue * 1.8) + 32;
            return Convert.ToInt32(tempResult);
        }

        public double ConvertCelciusToKelvin()
        {
            double tempResult = (temperatureValue + 273.15);
            return Convert.ToInt32(tempResult);
        }

        public double ConvertKelvinToFahrenheit()
        {
            double tempResult = ((temperatureValue - 273.15) * 1.8 + 32);
            return Convert.ToInt32(tempResult);
        }

        public double ConvertKelvinToCelsius()
        {
            double tempResult = (temperatureValue - 273.15);
            return Convert.ToInt32(tempResult);
        }

        public double ConvertFahrenheitToKelvin()
        {
            double tempResult = ((temperatureValue - 32) * 0.55 + 273.15);
            return Convert.ToInt32(tempResult);
        }

        public double ConvertFahrenheitToCelsius()
        {
            double tempResult = ((temperatureValue - 32) * 0.55);
            return Convert.ToInt32(tempResult);
        }
    }
}
