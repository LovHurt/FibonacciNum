using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Fibonacci number would you take?");
            int num = int.Parse(Console.ReadLine());
            Fibo(num);
            Console.ReadLine();
        }

        static void Fibo(int num)
        {
            ulong a = 0;
            ulong b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i <= num; i++)
            {
                ulong nextNumber = a + b;
                a = b;
                b = nextNumber;
                
                Console.WriteLine(nextNumber);
            }

        }
    }
}
