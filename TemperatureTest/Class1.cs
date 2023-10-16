using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170F23;
using NUnit.Framework;

namespace TemperatureTest
{
    [TestFixture]
    public class Class1
    {
        private Temp temperatureConverter;

        [SetUp]
        public void SetUp()
        {
            temperatureConverter = new Temp();
        }

        [Test]
        public void ValidTemperature_BoilingRange1_OutputBoiling()
        {
            // Arrange
            float temperature = 30.0f;
            string expected = "It's Boiling!!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidTemperature_BoilingRange2_OutputBoiling()
        {
            // Arrange
            float temperature = 35.0f;
            string expected = "It's Boiling!!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_BoilingRange3_OutputBoiling()
        {
            // Arrange
            float temperature = 40.0f;
            string expected = "It's Boiling!!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_NiceRange1_OutputNice()
        {
            // Arrange
            float temperature = 20.0f;
            string expected = "It's nice today";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_NiceRange2_OutputNice()
        {
            // Arrange
            float temperature = 25.0f;
            string expected = "It's nice today";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_NiceRange3_OutputNice()
        {
            // Arrange
            float temperature = 29.9f;
            string expected = "It's nice today";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_PleasantRange1_OutputPleasant()
        {
            // Arrange
            float temperature = 10.0f;
            string expected = "It's very pleasant";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_PleasantRange2_OutputPleasant()
        {
            // Arrange
            float temperature = 15.0f;
            string expected = "It's very pleasant";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_PleasantRange3_OutputPleasant()
        {
            // Arrange
            float temperature = 19.9f;
            string expected = "It's very pleasant";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_ColdRange1_OutputCold()
        {
            // Arrange
            float temperature = 0.0f;
            string expected = "Better get a coat. It's cold out there!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_ColdRange2_OutputCold()
        {
            // Arrange
            float temperature = 5.0f;
            string expected = "Better get a coat. It's cold out there!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTemperature_ColdRange3_OutputCold()
        {
            // Arrange
            float temperature = 9.9f;
            string expected = "Better get a coat. It's cold out there!";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTemperature_LowOutOfRange_OutputError()
        {
            // Arrange
            float temperature = -1.0f;
            string expected = "Your input temperature is not within the acceptable range";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTemperature_HighOutOfRange_OutputError()
        {
            // Arrange
            float temperature = 45.0f;
            string expected = "Your input temperature is not within the acceptable range";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidTemperature_VeryHighOutOfRange_OutputError()
        {
            // Arrange
            float temperature = 100.0f;
            string expected = "Your input temperature is not within the acceptable range";

            // Act
            string actual = temperatureConverter.TemperatureConverter(temperature);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}

    

