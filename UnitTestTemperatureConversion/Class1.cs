using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using temperatureConversion;

namespace UnitTestTemperatureConversion
{
    public class Class1
    {
        [Test]
        public void ConvertCelciusToFahrenheit40()
        {
            int testData = 40;
            double expectedResult = 104.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheit90()
        {
            int testData = 90;
            double expectedResult = 194.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheit136()
        {
            int testData = 136;
            double expectedResult = 277.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }
        //end of celcius to fahrenheit

        [Test]
        public void ConvertCelciusToKelvin50()
        {
            int testData = 50;
            double expectedResult = 323.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertCelciusToKelvin450()
        {
            int testData = 450;
            double expectedResult =723.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertCelciusToKelvin550()
        {
            int testData = 1520;
            double expectedResult = 1793.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedResult, result);
        }
        //end of celcius to kelvin
        [Test]
        public void ConvertKelvinToFahrenheit1560()
        {
            int testData = 1560;
            double expectedResult = 2348.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit1650()
        {
            int testData = 1650;
            double expectedResult = 2510.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit738()
        {
            int testData = 738;
            double expectedResult = 869.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedResult, result);
        }
        //end of kelvin to fahrenheit

        [Test]
        public void ConvertKelvinToCelsius486()
        {
            int testData = 486;
            double expectedResult = 213.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertKelvinToCelsius712()
        {
            int testData = 712;
            double expectedResult = 439.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertKelvinToCelsius867()
        {
            int testData = 867;
            double expectedResult = 594.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedResult, result);
        }
        //end of kelvin to celsius

        [Test]
        public void ConvertFahrenheitToKelvin23()
        {
            int testData = 23;
            double expectedResult = 268.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin156()
        {
            int testData = 156;
            double expectedResult = 341.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin789()
        {
            int testData = 789;
            double expectedResult = 690.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedResult, result);
        }

        //end of Fahrenheit to kelvin

        [Test]
        public void ConvertFahrenheitToCelsius60()
        {
            int testData = 60;
            double expectedResult = 15.00;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius185()
        {
            int testData = 185;
            double expectedResult = 84.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius250()
        {
            int testData = 250;
            double expectedResult = 120.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(testData);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
