using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questions
{
    class Question1
    {
        static void Main(string[] args)
        {
        }

        static int ParseHexInt(string hex)
        {
            int result = 0;
            int baseValue = 1;

            for (int i = hex.Length; i > 0 ; i--)
            {
                int hexNumber = HexCharToInt(hex.ElementAt(i - 1));
                int decNumber = hexNumber * baseValue;
                baseValue *= 16;
                result += decNumber;
            }

            return result;
        }

        public static int HexCharToInt(char h)
        {
            int result = -1;
            if ((h >= '0') && (h <= '9'))
            {
                result = (h - '0');
            }
            if ((h >= 'a') && (h <= 'f'))
            {
                result = ((h - 'a') + 10);
            }
            if ((h >= 'A') && (h <= 'F'))
            {
                result = ((h - 'A') + 10);
            }

            return result;
        }

        [TestClass]
        public class HexConverterTests
        {
            [TestMethod]
            public void ParseHexInt_BasicScenarios_Success()
            {
                //Arrange
                string hex1 = "1F";
                string hex2 = "A";
                string hex3 = "0";

                //Act
                int result1 = ParseHexInt(hex1);
                int result2 = ParseHexInt(hex2);
                int result3 = ParseHexInt(hex3);

                //Assert
                Assert.AreEqual(result1, 31);
                Assert.AreEqual(result2, 10);
                Assert.AreEqual(result3, 0);
            }
        }
    }
}