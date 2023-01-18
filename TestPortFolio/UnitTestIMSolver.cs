namespace TestPortFolio
{
    public class UnitTestIMSolver
    {
        [Theory]
        [InlineData(new uint[] { 0, 2 }, 2)]
        [InlineData(new uint[] { 4, 0 }, 4)]
        [InlineData(new uint[] { 8, 12, 20 }, 4)]
        [InlineData(new uint[] { 24, 56, 124, 67 }, 1)]
        [InlineData(new uint[] { 200, 450, 500, 800 }, 50)]
        public void TestGCD(uint[] value1, uint expected)
        {
            MathSolving ms = new MathSolving();

            uint result = ms.CalculateGCD(value1, true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new uint[] { 0, 2 }, 2)]
        [InlineData(new uint[] { 4, 0 }, 4)]
        [InlineData(new uint[] { 8, 12, 20 }, 120)]
        [InlineData(new uint[] { 24, 56, 124, 67 }, 348936)]
        [InlineData(new uint[] { 200, 450, 500, 800 }, 36000)]
        public void TestLCM(uint[] value1, uint expected)
        {
            MathSolving ms = new MathSolving();

            uint result = ms.CalculateGCD(value1, true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new uint[] { 0, 2 }, 2)]
        [InlineData(new uint[] { 4, 0 }, 4)]
        [InlineData(new uint[] { 8, 12, 20 }, 4)]
        [InlineData(new uint[] { 24, 56, 124, 67 }, 1)]
        [InlineData(new uint[] { 200, 450, 500, 800 }, 50)]
        public void TestQuadratic(uint[] value1, uint expected)
        {
            MathSolving ms = new MathSolving();

            uint result = ms.CalculateGCD(value1, true);

            Assert.Equal(expected, result);
        }
    }
}