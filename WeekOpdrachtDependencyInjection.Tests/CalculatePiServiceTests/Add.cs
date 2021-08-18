using Xunit;
using WeekOpdrachtDependencyInjection.Business;
using System;

namespace WeekOpdrachtDependencyInjection.Tests.CalculatePiServiceTests
{
    public class Add
    {
        [Fact]
        public void ItShould_AddIntegerToPi()
        {
            // Arrange
            CalculatePiService service = new CalculatePiService();

            // Act
            double piPlusOne = service.Add(1);

            // Assert
            Assert.Equal(Math.PI + 1, piPlusOne);
        }
    }
}
