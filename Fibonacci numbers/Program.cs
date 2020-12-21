using System;

namespace Fibonacci_numbers
{
    class Program
    {
        static int Fibonacci(int firstNum, int max, int count, int result, int secondNum)
        {
            Console.Write(result + " ");
            if (count < max-1)
            {
                result = secondNum + firstNum;
                firstNum = secondNum;
                secondNum = result;
                count++;
                return Fibonacci(firstNum, max, count, result, secondNum);
            }
            return secondNum;
        }
        static void Main(string[] args)
        {
            int firstNum = 0;
            int count = 0;
            int result = 1;
            int max = Int32.Parse(Console.ReadLine());
            int secondNum = 1;
            Console.Write(firstNum + " ");
            int fib = Fibonacci(firstNum, max, count, result, secondNum);
        }
    }
}