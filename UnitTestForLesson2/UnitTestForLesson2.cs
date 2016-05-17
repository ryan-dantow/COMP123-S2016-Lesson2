using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_S2016_Lesson2; 
namespace UnitTestForLesson2
{
    public class UnitTestForLesson2
    {
        public void addXandYTestMethod()
        {
            // Arrange
            int x = 0;
            int y = 0;
            int expectedResult = 90;

            // Act
            int result = Program.addXandY(x, y);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }


    }
}
