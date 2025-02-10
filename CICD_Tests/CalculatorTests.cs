using CICD_Core;

namespace CICD_Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            double result = Calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
        {
            double result = Calculator.Divide(-10, -2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(-99, 0));
        }
    }
}
