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
        /// Calculates the greatest common divisor of two positive integer numbers
        /// </summary>
        /// <param name="a">First integer number</param>
        /// <param name="b">Second integer number</param>
        /// <returns>Return -1 if any of the numbers are not positive </returns>
        private int gcd(int a, int b)
        {
            // Check that a and b are valid to
            // continue with the GCD calculation
            if (a < 0 || b < 0)
            {
                return -1;
            }
            else
            {
                // If any of the number is zero return the other number
                if (a == 0)
                    return b;
                if (b == 0)
                    return a;

                // If the numbers are equal
                if (a == b)
                    return a;

                // Recursivly find the GCD depending on which integer is larger
                if (a > b)
                {
                    return gcd(a - b, b);
                }
                else
                {
                    return gcd(a, b - a);
                }
            }
        }
        #endregion
        // Function to find gcd of array of 
        // numbers 
        public int GetGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++)
                result = gcd(arr[i], result);

            return result;
        }

        public int GetLCD(int[] arr, int n)
        {
            return 0;
        }
    }
}
