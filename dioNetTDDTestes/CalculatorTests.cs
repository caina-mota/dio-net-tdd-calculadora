using dioNetTDDCalculadora;

namespace DioNetTDDTestes
{
    public class CalculatorTests
    {
        private Calculator calc;
        public CalculatorTests()
        {
            calc = new Calculator();
        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void SumTest(int v1, int v2, int res)
        {
            int resCalc = calc.Sum(v1, v2);

            Assert.Equal(res, resCalc);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void SubTest(int v1, int v2, int res)
        {
            int resCalc = calc.Sub(v1, v2);

            Assert.Equal(res, resCalc);
        }

        [Theory]
        [InlineData(4, 7, 28)]
        [InlineData(9, 3, 27)]
        public void MultTest(int v1, int v2, int res)
        {
            int resCalc = calc.Mult(v1, v2);

            Assert.Equal(res, resCalc);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(9, 3, 3)]
        public void DivTest(int v1, int v2, int res)
        {
            int resCalc = calc.Div(v1, v2);

            Assert.Equal(res, resCalc);
        }

        [Fact]
        public void DivByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Div(3,0)); 
        }

        [Fact]
        public void HistoryTest()
        {
            calc.Sum(1, 2);
            calc.Sub(1, 2);
            calc.Div(1, 2);
            calc.Mult(1, 2);

            var history = calc.History();

            Assert.NotEmpty(history);
            Assert.Equal(3, history.Count);
        }


    }
}