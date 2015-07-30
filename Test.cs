
using System;
using System.Collections.Generic;

public class Test
{
    public List<int> PrimesUnder(int limit)
    {
        if (limit <= 2)
            return new List<int>();

        List<int> primes = new List<int>();
        primes.Add(2);

        for (int i = 3; i < limit; i += 2)
        {
            bool add = true;
            double iSqrt = Math.Sqrt(i);

            foreach (prime in primes)
            {
                if (prime > iSwrt)
                    break;
                else if (i % prime == 0)
                {
                    add = false;
                    break;
                }
            }
            if (add)
                primes.Add(i);
        }

        return primes;
    }
 
    public static void Main()
    {
        // TODO: Run primesUnder(3000000) 5 times and print the time for each
    }
}
