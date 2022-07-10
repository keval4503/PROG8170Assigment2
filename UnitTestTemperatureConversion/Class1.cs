using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit.Framework;
using temperatureConversion;

namespace UnitTestTemperatureConversion
{
    public class Class1
    {
        [Test]
        public void ConvertCelciusToFahrenheit30()
        {
            int tempdata = 30;
            double exp = 86.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheit80()
        {
            int tempdata = 80;
            double exp = 176.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertCelciusToFahrenheit125()
        {
            int tempdata = 125;
            double exp = 257.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(exp, result);
        }
        //end of celcius to fahrenheit

        [Test]
        public void ConvertCelciusToKelvin50()
        {
            int tempdata = 550;
            double exp = 823.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertCelciusToKelvin100()
        {
            int tempdata = 860;
            double exp = 1133;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertCelciusToKelvin550()
        {
            int tempdata = 1520;
            double exp = 1793.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }
        //end of celcius to kelvin
        [Test]
        public void ConvertKelvinToFahrenheit550()
        {
            int tempdata = 550;
            double exp = 823.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit1520()
        {
            int tempdata = 1520;
            double exp = 1793.0;
            temperatureConversion.Conversion _conv = new temperatureConversion.Conversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertKelvinToFahrenheit638()
        {
            int tempdata = 638;
            double exp = 911.0;
            temperatureConversion.Conversion _tempConversion = new temperatureConversion.Conversion(tempdata);
            double result = _tempConversion.ConvertCelciusToKelvin();
            Assert.AreEqual(exp, result);
        }
        //end of kelvin to fahrenheit

        [Test]
        public void ConvertKelvinToCelsius367()
        {
            int tempdata = 367;
            double exp = 94.0;
            temperatureConversion.Conversion _tempConversion = new temperatureConversion.Conversion(tempdata);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertKelvinToCelsius696()
        {
            int tempdata = 696;
            double exp = 423.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertKelvinToCelsius857()
        {
            int tempdata = 857;
            double exp = 584.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertKelvinToCelsius();
            Assert.AreEqual(exp, result);
        }
        //end of kelvin to celsius

        [Test]
        public void ConvertFahrenheitToKelvin59()
        {
            int tempdata = 59;
            double exp = 288.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin196()
        {
            int tempdata = 196;
            double exp = 363.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertFahrenheitToKelvin598()
        {
            int tempdata = 598;
            double exp = 584.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(exp, result);
        }

        //end of Fahrenheit to kelvin

        [Test]
        public void ConvertFahrenheitToCelsius60()
        {
            int tempdata = 60;
            double exp = 15.00;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius85()
        {
            int tempdata = 85;
            double exp = 29.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void ConvertFahrenheitToCelsius96()
        {
            int tempdata = 96;
            double exp = 35.0;
            temperatureConversion.temperatureConversion _tempConversion = new temperatureConversion.temperatureConversion(tempdata);
            double result = _tempConversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(exp, result);
        }
    }
}
