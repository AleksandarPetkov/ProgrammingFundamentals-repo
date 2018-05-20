using System;
using System.Collections.Generic;
using System.Linq;

class Sieve
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (primes[i] == true)
            {
                for (int j = i*i; j < n+1; j+=i)
                {
                    primes[j] = false;
                }
            }
        }

        for (int k = 2; k <= n; k++)
        {
            if (primes[k] == true)
            {
                Console.Write(k+" ");
            }
        }
    }
}

