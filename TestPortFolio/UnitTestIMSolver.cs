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
            // Arrange
            MathSolving ms = new MathSolving();

            // Act
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
            // Arrange
            MathSolving ms = new MathSolving();

            // Act
            uint result = ms.CalculateLCM(value1);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1.0, 4.0, 2.0, -0.59, -3.41)]
        [InlineData(1.0, -8.0, 1.0, 7.87, 0.127)]
        [InlineData(0.5, 0.2, 0.02, -0.2, -0.2)]
        public void TestQuadraticRealTwoRoots(double a, double b, double c, double rootOne, double rootTwo)
        {
            // Arrange
            double root1;
            double root2;
            MathSolving ms = new MathSolving();

            // Act
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
            // Arrange
            double root1;
            double root2;
            MathSolving ms = new MathSolving();

            // Act            
            bool hasRealRoots = ms.CalculateQuadraticEquation(a, b, c, out root1, out root2);

            Assert.True(hasRealRoots && (Math.Abs(rootOne - root1) < 0.01) && (root1 == root2));
        }

        [Theory]
        [InlineData(1.0, -3.0, 10.0, 1.5, 2.78)]
        [InlineData(5.0, 0.0, 320.0, 0.0, 8)]
        [InlineData(1.0, -4.0, 8.0, 2.0, 2.0)]
        public void TestQuadraticImaginaryRoots(double a, double b, double c, double realPart, double imaginaryPart)
        {
            // Arrange
            double real;
            double imaginary;
            MathSolving ms = new MathSolving();

            // Act            
            bool hasRealRoots = ms.CalculateQuadraticEquation(a, b, c, out real, out imaginary);

            Assert.True(!hasRealRoots && ((Math.Abs(real - realPart) < 0.01) && (Math.Abs(imaginary - imaginaryPart) < 0.01)));
        }

        [Theory]
        [InlineData(0, 2, false)]
        [InlineData(1, 0, true)]
        [InlineData(1, 2, true)]
        [InlineData(-1, -2, true)]
        [InlineData(-1, 2, true)]
        [InlineData(1, -2, true)]
        public void TestLinearEquationHasSolution(int a, int b, bool expected)
        {
            // Arrange
            double result;
            MathSolving ms = new MathSolving();

            // Act            
            bool HasSolution = ms.SolveLinearEquation(a, b, out result);

            // Assert
            Assert.Equal(expected, HasSolution);
        }

        [Theory]
        [InlineData(1, 0, 0.0)]
        [InlineData(0, 2, 0.0)]
        [InlineData(1, 2, -2.0)]
        [InlineData(2, -14, 7.0)]
        [InlineData(-11, 27, 2.45)]
        [InlineData(-2, -4, -2.0)]
        public void TestLinearEquationCalculation(int a, int b, double expected)
        {
            // Arrange
            double result;
            MathSolving ms = new MathSolving();

            // Act            
            ms.SolveLinearEquation(a, b, out result);

            // Assert
            Assert.Equal(expected, result, 2);
        }

        [Theory]
        [InlineData(-2.0,
            new[] { 1, 2 },
            new[] { 3, 4 })]
        [InlineData(-14.0,
            new[] { 3, 8 },
            new[] { 4, 6 })]
        public void TestMatrixDeterminant2x2(double determinant, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();

            int[,] matrix2x2 = new int[2, 2];
            for (int i = 0; i < 2; ++i)
                for (int j = 0; j < 2; ++j)
                    matrix2x2[i, j] = matrix[i][j];

            // Act
            double det = ms.DeterminantOfMatrix(matrix2x2);
            Assert.Equal(determinant, det);
        }

        [Theory]
        [InlineData(-306.0,
            new[] { 6, 1, 1 },
            new[] { 4, -2, 5 },
            new[] { 2, 8, 7 })]
        [InlineData(-4.0,
            new[] { 2, -1, 0 },
            new[] { 3, -5, 2 },
            new[] { 1, 4, -2 })]
        public void TestMatrixDeterminant3x3(double determinant, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();

            int[,] matrix3x3 = new int[3, 3];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    matrix3x3[i, j] = matrix[i][j];

            // Act
            double det = ms.DeterminantOfMatrix(matrix3x3);
            Assert.Equal(determinant, det);
        }

        [Theory]
        [InlineData(-810.0,
            new[] { 0, 2, 1, -9 },
            new[] { 4, -3, 2, -3 },
            new[] { 0, 3, 2, 12 },
            new[] { 1, -1, -3, 6 })]
        [InlineData(75.0,
            new[] { 3, -2, 1, 7 },
            new[] { -2, 3, 6, 2 },
            new[] { 1, -2, -4, 3 },
            new[] { 1, 0, 0, 2 })]
        public void TestMatrixDeterminant4x4(double determinant, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();

            int[,] matrix4x4 = new int[4, 4];
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    matrix4x4[i, j] = matrix[i][j];

            // Act
            double det = ms.DeterminantOfMatrix(matrix4x4);
            Assert.Equal(determinant, det);
        }

        [Theory]
        [InlineData(new double[] { -5.0, 3.5 },
            new[] { 1, 2, 2 },
            new[] { 3, 4, -1 })]
        [InlineData(new double[] { 0, 0 },
            new[] { 3, 8, 0 },
            new[] { 4, 6, 0 })]
        public void TestLinearSystem2Unknowns(double[] expected, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();
            double[] result;
            int[,] matrix2x3 = new int[2, 3];
            for (int i = 0; i < 2; ++i)
                for (int j = 0; j < 3; ++j)
                    matrix2x3[i, j] = matrix[i][j];

            // Act
            ms.SolveLinearSystem(matrix2x3, out result);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { -0.43, 1, -1.29 },
            new[] { 1, 2, 2, -1 },
            new[] { 3, 4, -1, 4 },
            new[] { 2, -1, -3, 2 })]
        [InlineData(new double[] { 0, 0, 0 },
            new[] { 3, 8, 1, 0 },
            new[] { 4, 6, 3, 0 },
            new[] { 1, 2, 2, 0 })]
        public void TestLinearSystem3Unknowns(double[] expected, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();
            double[] result;
            int[,] matrix3x4 = new int[3, 4];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 4; ++j)
                    matrix3x4[i, j] = matrix[i][j];

            // Act
            ms.SolveLinearSystem(matrix3x4, out result);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(false,
            new[] { -4, 10, 6 },
            new[] { 2, -5, 3 })]
        [InlineData(true,
            new[] { 1, 2, 2 },
            new[] { 3, 4, -1 })]
        public void TestLinearSystem2UnknownsNoSolution(bool expected, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();
            double[] result;
            int[,] matrix2x3 = new int[2, 3];
            for (int i = 0; i < 2; ++i)
                for (int j = 0; j < 3; ++j)
                    matrix2x3[i, j] = matrix[i][j];

            // Act
            bool HasSolution = ms.SolveLinearSystem(matrix2x3, out result);

            // Assert
            Assert.Equal(expected, HasSolution);
        }

        [Theory]
        [InlineData(false,
            new[] { 1, 1, 1, 1 },
            new[] { 1, 1, 1, 2 },
            new[] { 1, 1, 1, 3 })]
        [InlineData(true,
            new[] { 3, 8, 1, 0 },
            new[] { 4, 6, 3, 0 },
            new[] { 1, 2, 2, 0 })]
        public void TestLinearSystem3UnknownsNoSolution(bool expected, params int[][] matrix)
        {
            // Arrange
            MathSolving ms = new MathSolving();
            double[] result;
            int[,] matrix3x4 = new int[3, 4];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 4; ++j)
                    matrix3x4[i, j] = matrix[i][j];

            // Act
            bool HasSolution = ms.SolveLinearSystem(matrix3x4, out result);

            // Assert
            Assert.Equal(expected, HasSolution);
        }
    }
}