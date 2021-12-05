using System;

namespace ThreadsHW
{
    internal class FibonacciNumberFinder
    {
        private const int first = 0, second = 1;
        private int num1, num2;

        public FibonacciNumberFinder()
        {
            num1 = first;
            num2 = second;
        }

        public int Next()
        {
            int num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
            return num2;
        }

        public void Reset()
        {
            num1 = first;
            num2 = second;
        }
    }
}