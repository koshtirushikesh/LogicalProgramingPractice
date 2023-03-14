
using System;

namespace ConsoleApp23
{
    internal class Class2
    {
        public void EvenOdd()
        {
            int num = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine("Even"+i);
                }
                else
                    Console.WriteLine("odd" + i);
            }
        }

        public void PositveOrNegativ()
        {
            int num = 0;
            if (num < 0)
                Console.WriteLine("negativ number");
            else
                Console.WriteLine("possitive number");
        }

    }
}
