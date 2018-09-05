using BabySitterKata.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BabySitterKata.UnitTests.CalculatorTests
{
    [TestFixture]
    public class TimeConversionUnitTests
    {
        [TestCaseSource("GetTestCasesForTimeConversion")]
        public void GetDateMethodReturnsCorrectDateTime(string time, DateTime expectedTime)
        {
            // Arrange
            ITimeConversionService service = new TimeConversionService();

            // Act
            var result = service.GetDate(time);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expectedTime);
        }

        private static IEnumerable<TestCaseData> GetTestCasesForTimeConversion()
        {
            yield return new TestCaseData("5:00PM", DateTime.Today.AddHours(17));
            yield return new TestCaseData("6:00PM", DateTime.Today.AddHours(18));
            yield return new TestCaseData("7:00PM", DateTime.Today.AddHours(19));
            yield return new TestCaseData("8:00PM", DateTime.Today.AddHours(20));
            yield return new TestCaseData("9:00PM", DateTime.Today.AddHours(21));
            yield return new TestCaseData("10:00PM", DateTime.Today.AddHours(22));
            yield return new TestCaseData("11:00PM", DateTime.Today.AddHours(23));
            yield return new TestCaseData("12:00AM", DateTime.Today.AddHours(24));
            yield return new TestCaseData("1:00AM", DateTime.Today.AddHours(25));
            yield return new TestCaseData("2:00AM", DateTime.Today.AddHours(26));
            yield return new TestCaseData("3:00AM", DateTime.Today.AddHours(27));
            yield return new TestCaseData("4:00AM", DateTime.Today.AddHours(28));
        }
    }
}
