using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Odd(number);
            Even(number);
            Prime(number);
            Console.WriteLine(" input 2nd number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is square of {1}", Square(number), number);
            Console.WriteLine("{0} is cube of {1}", Square(number), number);
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static void Odd(int number) 
        {
            IsOdd(number);
            if (IsOdd(number)) {
                Console.WriteLine("odd");
            }
            else {
                Console.WriteLine("0");
            }
        }
        public static bool IsEven(int number) 
        {
            return number % 2 == 0;
        }
        static void Even(int number)
        {
            IsEven(number);
            if (IsEven(number))
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        public static bool IsPrime(int number)
        {
            if (number < 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Prime(int number)
        {
            if (IsPrime(number))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        public static int Square(int number2)
        {
            return number2 * number2;
        }
        public static int Cube(int number2)
        {
            return number2 * number2 * number2;
        }
    }
}
