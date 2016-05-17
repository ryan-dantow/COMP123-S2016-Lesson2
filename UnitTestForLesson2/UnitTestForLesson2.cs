using System;
using COMP123_S2016_Lesson2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTestForLesson2
    {
        private object Assert;

        [TestMethod]
        public void addXandYTestMethod()
        {
            // Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            // Act 
            int result = Program.addXandY(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void addYtoXTestMethod()
        {
            // Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            // Act 
            int result = Program.addYtoX(ref x, ref y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}
