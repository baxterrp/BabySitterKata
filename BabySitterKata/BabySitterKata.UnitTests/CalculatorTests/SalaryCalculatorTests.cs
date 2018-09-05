using BabySitterKata.Interfaces;
using NUnit.Framework;

namespace BabySitterKata.UnitTests.CalculatorTests
{
    [TestFixture]
    public class SalaryCalculatorTests
    {

        [Test]
        public void CallingSalaryCalculatorWithStringsReturnsNotNull()
        {
            // Arrange
            ISalaryCalculator calculator= new SalaryCalculator();
            string startTime = "4:00PM";
            string endTime = "5:00PM";

            // Act
            var result = calculator.Calculate(startTime, endTime);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
