
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

        public void MultipalOF_2And3(int number)
        {
            if (number % 2 == 0 && number % 3 == 0)
                Console.WriteLine(number + ": is divisable by 2 and 3");
            else
                Console.WriteLine(number + ": is not divisable by 2 and 3");
        }
    }
}
