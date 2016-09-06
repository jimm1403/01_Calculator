using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int no1, int no2)
        {
            return no1 + no2;
        }

        internal static object Subtract(int no1, int no2)
        {
            return no1 - no2;
        }

        internal static int Sum(int[] numbers)
        {
            int _sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                _sum += numbers[i];
            }
            return _sum;
        }

        internal static int Multiply(int[] numbers)
        {
            int _multiplySum = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                _multiplySum *= numbers[i];
            }

            return _multiplySum;
        }

        internal static double Power(double no1, double no2)
        {
            return Math.Pow(no1, no2);
        }

        internal static int Factorial(int no1)
        {
            int result = 1;
            for (int i = no1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}