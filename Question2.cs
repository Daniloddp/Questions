using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questions
{
    class Question2
    {
        static int FindMaxSum(List<int> list)
        {
            int bigger = int.MinValue;
            int secondBigger = int.MinValue;

            foreach (var item in list)
            {
                if (item > bigger)
                {
                    secondBigger = bigger;
                    bigger = item;
                }
                else if (item > secondBigger)
                {
                    secondBigger = item;
                }
            }

            return bigger + secondBigger;
        }

        [TestClass]
        public class SumTests
        {
            [TestMethod]
            public void FindMaxSum_PositiveNumbers_Success()
            {
                //Arrange
                List<int> list1 = new List<int>() { 1, 10, 3, 7, 9 };
                List<int> list2 = new List<int>() { 200, 40, 3, 537, 184 };
                List<int> list3 = new List<int>() { 200, 40, 3, 537, 384 };

                //Act
                int result1 = FindMaxSum(list1);
                int result2 = FindMaxSum(list2);
                int result3 = FindMaxSum(list3);

                //Assert
                Assert.AreEqual(result1, 19);
                Assert.AreEqual(result2, 737);
                Assert.AreEqual(result3, 921);
            }

            [TestMethod]
            public void FindMaxSum_PositiveAndNegativeNumbers_Success()
            {
                //Assert
                List<int> list1 = new List<int>() { -200, 40, 3, -537, -184 };
                List<int> list2 = new List<int>() { -2, 1, -1, 0 };

                //Act
                int result1 = FindMaxSum(list1);
                int result2 = FindMaxSum(list2);

                //Assert
                Assert.AreEqual(result1, 43);
                Assert.AreEqual(result2, 1);
            }

            [TestMethod]
            public void FindMaxSum_OnlyNegativeNumbers_Success()
            {
                //Arrange
                List<int> list = new List<int>() { -6, -2, -9, -537, -184 };

                //Act
                int result = FindMaxSum(list);

                //Assert
                Assert.AreEqual(result, -8);
            }
        }
    }
}