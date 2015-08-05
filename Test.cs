
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Test
{
    public static List<int> PrimesUnder(int limit)
    {
        if (limit <= 2)
            return new List<int>();

        List<int> primes = new List<int>();
        primes.Add(2);

        for (int i = 3; i < limit; i += 2)
        {
            bool add = true;
            double iSqrt = Math.Sqrt(i);

            foreach (var prime in primes)
            {
                if (prime > iSqrt)
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
        List<long> times = new List<long>();
        var stopwatch = new Stopwatch();
        for (int i = 0; i < 5; i++)
        {
            stopwatch.Start();
            List<int> result = PrimesUnder(3000000);
            stopwatch.Stop();

            times.Add(stopwatch.ElapsedMilliseconds);
			stopwatch.Reset();
        }

        foreach (var time in times)
            Console.WriteLine(time);
    }
}
