using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Operations
    {
        // find the nth prime
        public static int NthPrime(int n)
        {
            // automatically return 2 if the prime 1 is requested
            if (n == 1) { return 2; }
            // begin count at 3 since 3 primes are already accounted for
            int count = 1;
            // begin primeCandidate at 1 so that on the initial increment it becomes 3
            int primeCandidate = 1;
            // initialize divisor at 2 in order to catch the second prime (3)
            // after the first inner while loop it is always reset to 3
            int divisor = 2;
            // keep iterating until the number of primes found (count) == n
            while (n != count)
            {
                // increment the candidate by 2 to skip evens
                primeCandidate += 2;
                // calculate the square root for later use
                int root = Convert.ToInt32(Math.Ceiling(Math.Sqrt(primeCandidate)));
                // only test while the divisor is less than the root
                while (divisor <= root)
                {
                    // check for divisibility
                    if (primeCandidate % divisor == 0)
                    {
                        // if divisible, move to the next candidate
                        primeCandidate += 2;
                        // reset divisor for next candidate
                        divisor = 3;
                        // jump to the loop beginning
                        continue;
                    }
                    // if the divisor reaches the root, we've found a prime
                    if (divisor > root - 1)
                    {
                        // record that the prime was found
                        count++;
                        break;
                    }
                    // increment divisor and try again if none of the above conditions are met
                    divisor++;
                }
                // reset the divisor for the next iteration of the while loop
                divisor = 3;
            }
            return primeCandidate;
        }

        // calculate the nth Fibonacci number
        public static int NthFibonacci(int n)
        {
            // formula for the nth Fibonacci number
            return Convert.ToInt32((Math.Pow(PHI, Convert.ToDouble(n) + 1) - Math.Pow(PSI, Convert.ToDouble(n) + 1)) / ROOT5);
            // formula is (phi**(n + 1) - psi**(n + 1)) / sqrt(5)
        }

        // calculate the nth Lucas number
        public static int NthLucas(int n)
        {
            // formula for the nth Lucas number
            return Convert.ToInt32(Math.Pow(PHI, Convert.ToDouble(n) + 1) + Math.Pow(PSI, Convert.ToDouble(n) + 1));
            // formula is phi**(n + 1) + psi**(n + 1)
        }
        // create math constants for NthFibonacci and NthLucas
        private static readonly double
            PHI = (1 + Math.Sqrt(5)) / 2,
            PSI = (1 - Math.Sqrt(5)) / 2,
            ROOT5 = Math.Sqrt(5);
    }
}
