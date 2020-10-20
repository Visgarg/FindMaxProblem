using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxProblem;

namespace findMaxMSTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [DataRow(45, 47, 60, 60)]
        [DataRow(45, 122, 60, 122)]
        [DataRow(440, 47, 60, 440)]
        public void MaxFromThreeIntegers(int a, int b, int c, int expected)
        {
            //Arrange
            //add
            int actual= NonGenericClass.MaxIntegerNumberAmongThree(a, b, c);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
