﻿using System;

namespace Algorithms.DataStructures.Common
{
    public static class PrimeList
    {
        public static int GetNextPrime(int currentPrime)
        {
            var found = false;
            var nextPrime = currentPrime;
            while (!found)
            {
                nextPrime++;
                found = isPrime(nextPrime);
            }

            return nextPrime;
        }

        private static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            var isPrime = true;
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}