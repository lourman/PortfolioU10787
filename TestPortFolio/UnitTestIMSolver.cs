namespace TestPortFolio
{
    public class UnitTestIMSolver
    {
        [Theory]
        [InlineData(new int[] { -1, 2}, -1)]
        [InlineData(new int[] { 10, -3 }, -1)]
        [InlineData(new int[] { 0, 2 }, 2)]
        [InlineData(new int[] { 4, 0 }, 4)]
        [InlineData(new int[] { 8, 12, 20 }, 4)]
        [InlineData(new int[] { 24, 56, 124, 67 }, 1)]
        public void TestGCD(int[] value1, int expected)
        {
            MathSolving ms = new MathSolving();

            int result = ms.GetGCD(value1, value1.Length);

            Assert.Equal(expected, result);
        }
    }
}