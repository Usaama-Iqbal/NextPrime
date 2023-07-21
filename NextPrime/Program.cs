using System;

public class prime
{
    public static void Main(string[] args)
    {
        int N ;
        Console.Write("Please enter a prime number : ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int nextPrime = N + 1; ; nextPrime++)
        {
            if (IsPrime(nextPrime))
            {
                Console.Write("The Next Prime Number Is : "+nextPrime);
                break;
            }
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }

    //static bool IsPrime(int n)
    //{
    //    if (n <= 1)
    //        return false;
    //    if (n <= 3) 
    //        return true;

    //    if (n % 2 == 0 || n % 3 == 0)
    //        return false;

    //    for (int i = 5; i * i <= n; i += 6)
    //    {
    //        if (n % i == 0 || n % (i + 2) == 0)
    //            return false;
    //    }

    //    return true;
    //}
}
