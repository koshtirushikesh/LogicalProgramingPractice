
using System;

namespace ConsoleApp23
{
    internal class Class2
    {
        public void EvenOdd()
        {
            int num = 3;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine("Even"+i);
                }
                else
                    Console.WriteLine(num + " odd");
            }
        }

        public void PositveOrNegativ(int num)
        {
            if (num < 0)
                Console.WriteLine("negativ number");
            else
                Console.WriteLine("possitive number");
        }

        public void LargestOfTwo(int num1, int num2)
        {
            if (num1 < num2)
                Console.WriteLine("large number is: " + num2);
            else
                Console.WriteLine("large number is: " + num1);
        }

        public void SwapNumber(int num1, int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = num1;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
        }

        public void NumberDivisebalBy2(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine(number + ": is divisable by 2");
            else
                Console.WriteLine(number + ": is not divisable by 2");
        }

        public void MultipalOF_2And3(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum of multipal of 2 and 3: " + sum);
        }

        public void MultipalOf_17(int max)
        {
            Console.Write("Multipal of 17: ");
            for (int i = 1; i <= max; i++)
                if (i % 17 == 0)
                    Console.Write(i + " ");
        }

        public void SumOfDigitsOfNumber(int number)
        {
            int num = number;
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum += rem;
                num = num / 10;
            }
            Console.WriteLine("\nsum : " + sum);
        }


        public void ReveerseNumber(int number)
        {
            int num = number;
            int revNum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number: " + revNum);
        }
    }
}
