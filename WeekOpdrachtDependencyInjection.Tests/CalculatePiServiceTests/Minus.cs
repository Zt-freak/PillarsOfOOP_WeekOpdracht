using System;
using WeekOpdrachtDependencyInjection.Business;
using Xunit;

namespace WeekOpdrachtDependencyInjection.Tests.CalculatePiServiceTests
{
    public class Minus
    {
        [Fact]
        public void ItShould_SubtractIntegerFromPi()
        {
            // Arrange
            CalculatePiService service = new CalculatePiService();

            // Act
            double piPlusOne = service.Minus(1);

            // Assert
            Assert.Equal(Math.PI - 1, piPlusOne);
        }
    }
}
