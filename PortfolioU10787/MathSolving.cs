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
        /// <returns>GCD of all all poisitve integers.</returns>
        public uint CalculateGCD(uint[] pintegers, bool PrimeFactorisation)
        {
            uint result = pintegers[0];
            for (int i = 1; i < pintegers.Length; i++)
            {
                result = PrimeFactorisation ? PrimeFactorisationGCDCalculation(result, pintegers[i]) : EuclidianGCDCalculation(result, pintegers[i]);
                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetLCM(int[] arr)
        {
            return 0;
        }
    }
}
