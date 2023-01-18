using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PortfolioU10787
{
    public class MathSolving
    {
        #region Private Methods

        /// <summary>
        /// Checks if an array has any element that is zeor
        /// </summary>
        /// <param name="pintegers"></param>
        /// <returns>True if no zero was found, False if at least one element is zero </returns>
        private bool ArrayHasNoZeros(uint[] pintegers)
        {
            for (int i = 0; i < pintegers.Length; i++)
            {
                if (pintegers[i] == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Use the Euclidean Algorithm to calculate the GCD of two positive integers.
        /// </summary>
        /// <param name="a">First Positive Number</param>
        /// <param name="b">Second Positive Number</param>
        /// <returns>Recursivly finding the evenly divides between the inputs</returns>
        private uint EuclidianGCDCalculation(uint a, uint b)
        {
            if (a == 0 || b == 0) // Base cases.
                return a + b;
            else if (a == b)
                return a;
            else if (a > b) // Euclid's Algorithm.
                return EuclidianGCDCalculation(a - b, b);
            return EuclidianGCDCalculation(a, b - a);
        }

        /// <summary>
        /// Find the common factors of two positive integers to find the GCD.
        /// </summary>
        /// <param name="a">First Positive Number</param>
        /// <param name="b">Second Positive Number</param>
        /// <returns>The product of the common factors as the GCD</returns>
        private uint PrimeFactorisationGCDCalculation(uint a, uint b)
        {
            // GCD(a, 0) = GCD(0, a) = a.
            if (a == 0 || b == 0) return a + b;

            // Calling the getFactors() function to store the factors of a and b.
            List<uint> afac = getFactors(a);
            List<uint> bfac = getFactors(b);

            // Initializing the GCD variable to store GCD.
            uint GCD = 1;
            int i = 1, j = 1;

            // Multiplying the GCD with the common factors of a and b.
            while (i < afac.Count() && j < bfac.Count())
            {
                // increment i or j by 1 depending on which is larger
                if (afac[i] < bfac[j])
                    i++;
                else if (afac[i] > bfac[j])
                    j++;
                else
                {
                    // if afac[i] == bfac[j], i.e., Common factors
                    GCD *= afac[i];
                    i++;
                    j++;
                }
            }

            return GCD;
            ;
        }


        /// <summary>
        /// Find all prime factors of an integer number.
        /// </summary>
        /// <param name="a">The integers numbers to factorise</param>
        /// <returns>A list of all prime factors</returns>
        List<uint> getFactors(uint a)
        {
            List<uint> factors = new List<uint>();

            // All numbers have 1 as the first factor although it is not a prime number
            factors.Add(1);

            //Finding the prime factors of the integer number.
            uint i = 2;
            while (a != 1)
            {
                while (a % i == 0)
                {
                    factors.Add(i);
                    a /= i;
                }
                i++;
            }

            return factors;
        }
        #endregion
        // Function to find gcd of array of 
        // numbers 
        /// <summary>
        /// Find the GCD of multiple positive numbers with two different methods
        /// </summary>
        /// <param name="pintegers">The array of all integers for which to calculate the GCD.</param>
        /// <param name="PrimeFactorisation">True if using prime factorisation method, False if using Euclidean algorith,</param>
        /// <returns>GCD of all all poisitve integers. Zero if at least one element of the integer array is zero</returns>
        public uint CalculateGCD(uint[] pintegers, bool PrimeFactorisation)
        {
            uint result = 0;
            if (ArrayHasNoZeros(pintegers))
            {
                result = pintegers[0];
                for (int i = 1; i < pintegers.Length; i++)
                {
                    result = PrimeFactorisation ? PrimeFactorisationGCDCalculation(result, pintegers[i]) : EuclidianGCDCalculation(result, pintegers[i]);
                    if (result == 1)
                    {
                        return 1;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Calculates the Least Common Multiple of multiple positive integers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>LCM of all all poisitve integers. Zero if at least one element of the integer array is zero</returns>
        public uint CalculateLCM(uint[] arr)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solves the quadratic equation. It returns real and imaginary roots.
        /// </summary>
        /// <param name="a">The coefficient of the x squared term</param>
        /// <param name="b">The coefficient of the x squared term</param>
        /// <param name="c">The constant term</param>
        /// <param name="root1">Returns a one element array with the element being the first root
        ///                     Returns a two element array with the first element being the real part and the second
        ///                     the imaginary part of the first root</param>
        /// <param name="root1">Returns a one element array with the element being the root
        ///                     Returns a two element array with the first element being the real part and the second
        ///                     the imaginary part of the second root</param>
        /// <returns> True if equation has real solutions, False if not
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool CalculateQuadraticEquation(double a, double b, double c, out double root1_Real, out double root2_Imag)
        {
            throw new NotImplementedException();
        }

        public double SolveLinearEquation(double a, int b)
        {
            throw new NotImplementedException();
        }

        public double determinantOfMatrix(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        // This function finds the solution of system of
        // linear equations using cramer's rule
        public void SolveLinearSystem(int[,] coefficients)
        {
            throw new NotImplementedException();
        }
    }
}
