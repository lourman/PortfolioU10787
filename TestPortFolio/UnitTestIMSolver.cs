namespace TestPortFolio
{
    public class UnitTestIMSolver
    {
        [Theory]
        [InlineData(new uint[] { 0, 2 }, 0)]
        [InlineData(new uint[] { 4, 0 }, 0)]
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
        [InlineData(new uint[] { 0, 2 }, 0)]
        [InlineData(new uint[] { 4, 0 }, 0)]
        [InlineData(new uint[] { 8, 12, 20 }, 120)]
        [InlineData(new uint[] { 24, 56, 124, 67 }, 348936)]
        [InlineData(new uint[] { 200, 450, 500, 800 }, 36000)]
        public void TestLCM(uint[] value1, uint expected)
        {
            MathSolving ms = new MathSolving();

            uint result = ms.CalculateLCM(value1);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1.0, 4.0, 2.0, -0.59, -3.41 )]
        [InlineData(1.0, -8.0, 1.0, 7.87, 0.127)]
        [InlineData(0.5, 0.2, 0.02, -0.2, -0.2)]
        public void TestQuadraticRealTwoRoots(double a, double b, double c, double rootOne, double rootTwo)
        {
            MathSolving ms = new MathSolving();

            double root1;
            double root2;
            bool hasRealRoots = ms.CalculateQuadraticEquation(a, b, c, out root1, out root2);
            
            Assert.True(hasRealRoots && ((Math.Abs(rootOne - root1) < 0.01) && (Math.Abs(rootTwo - root2) < 0.01) ||
                        ((Math.Abs(rootOne - root2) < 0.01) && (Math.Abs(rootTwo - root1) < 0.01))));

        }

        [Theory]
        [InlineData(1.0, -2.0, 1.0, 1, 1)]
        [InlineData(4.0, -12.0, 9.0, 1.5, 1.5)]
        [InlineData(-1.6, 2.4, -0.9, 0.75, 0.75)]
        public void TestQuadraticRealOneRoot(double a, double b, double c, double rootOne, double rootTwo)
        {
            MathSolving ms = new MathSolving();

            double root1;
            double root2;
            bool hasRealRoots = ms.CalculateQuadraticEquation(a, b, c, out root1, out root2);

            Assert.True(hasRealRoots && (Math.Abs(rootOne - root1) < 0.01) && (root1 == root2));

        }

        [Theory]
        [InlineData(1.0, -3.0, 10.0, 1.5, 2.78)]
        [InlineData(5.0, 0.0, 320.0, 0.0, 8)]
        [InlineData(1.0, -4.0, 8.0, 2.0, 2.0)]
        public void TestQuadraticImaginaryRoots(double a, double b, double c, double realPart, double imaginaryPart)
        {
            MathSolving ms = new MathSolving();

            double real;
            double imaginary;
            bool hasRealRoots = ms.CalculateQuadraticEquation(a, b, c, out real, out imaginary);

            Assert.True(!hasRealRoots && ((Math.Abs(real - realPart) < 0.01) && (Math.Abs(imaginary - imaginaryPart) < 0.01)));

        }
    }
}