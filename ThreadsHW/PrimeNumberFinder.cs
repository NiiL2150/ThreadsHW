using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreadsHW
{
    internal class PrimeNumberFinder
    {
        private List<int> primeNumbers;
        private List<int> userPrimeNumbers;
        private int userIndex;

        public PrimeNumberFinder()
        {
            primeNumbers = new List<int>();
            userPrimeNumbers = new List<int>();

            FillPrime(3, Int16.MaxValue);
        }

        private void FillPrime(int start, int finish)
        {
            primeNumbers.Add(2);
            for (int i = start; i < finish; i++)
            {
                bool isPrime = true;
                for (int j = 0; j < primeNumbers.Count; j++)
                {
                    if (i % primeNumbers[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
        }

        public void FindPrime(int start, int finish)
        {
            userPrimeNumbers.Clear();
            userPrimeNumbers.AddRange(primeNumbers.FindAll(x => x >= start && x < finish));
            userIndex = 0;
        }

        public int? NextPrime()
        {
            if(userIndex >= userPrimeNumbers.Count)
            {
                return null;
            }

            return userPrimeNumbers[userIndex++];
        }
    }
}