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
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is of math pow, {1} and {2}", pow(number2, number3), number2, number3);
            Console.WriteLine("{0} is abs of {1}", abs(number3), number3);
            Console.WriteLine("The number u want it to be ceil and floor");
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} is ceil {1} ", Ceil(number4), number4);
            Console.WriteLine("{0} is floor {1} ", Floor(number4), number4);
            Console.WriteLine("{0} is lucky number ", Random(number));
            Console.WriteLine("{0} is random2 ", random2());
         
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
        public static double pow(int number2, int number3)
        {
            double result = 1;
            if (number3 > 0)
            {
                for (int i = 0; i < number3; i++)
                {
                    result = result * number2;
                }
            }
            else if (number3 < 0)
            {
                double temp;
                for (int i = 0; i < Math.Abs(number3); i++)
                {
                    result = (result * number2);
                }
                temp = 1 / result;
                result = temp;
            }
            return result;
        }
         public static int abs (int number3) 
         {
             if (number3 == 0)
             {
                 return 1;
             }
             if (number3 > 0)
             {
                 return number3;
             }
             return number3 * -1;
         }
         public static int Ceil(double number4)
         {
             //so nguyen
             if (number4 > 0 && number4 % 1 != 0)
             {
                 return (int)number4 + 1;
             }
             else if (number4 < 0 && number4 % 1 != 0)
             {
                 return (int)number4;
             }
             else
             {
                 return (int)number4;
             }

         }
         public static int Floor(double number4)
         {
             if (number4 < 0)
             {
                 return (int)number4 + -1;
             }

             return (int)number4;
         }
        //input: float x
        //output: a int the largest integral value that is not greater than x
        //idea: first chang float x into interger
        //if x is a negative --1
        //if number == k then unchange

         //public static int Floor(float number)
         //{
            //if (number < 0 && number % 1 != 0)
            //{
            //    return(int) number;
            //}
            //else if (number > 0 && number % 1 != 0)
            //{
            //    return (int)number;
            //}
            //return (int)number;
            ///////////////////////// code2:
            ////////////////////////int a = (int)number;
            ////////////////////////if (number < 0)
            ////////////////////////{
            ////////////////////////    if (a != number)
            ////////////////////////    {
            ////////////////////////        a = a - 1;
            ////////////////////////    }
            ////////////////////////}
            ////////////////////////return a;
         public static int Random(int number)
         {
             Random rd = new Random();
             return number = rd.Next(0, 100000);
         }
         public static float random2()
         {
             Random rd2 = new Random();
             return rd2.Next(0, 1);
         }
         public static long factonrial(long x)
         {
             int result = 1;
             for (int i = 1; i <= x; i++)
             {
                 result = result * i;
             }
             return result;
         }
    }
}
