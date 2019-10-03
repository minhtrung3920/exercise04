using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////int Length = Convert.ToInt32(Console.ReadLine());
            ///Length
            ////int[] array = new int[10];
            ////Console.WriteLine("nhap phan tu mang: ");
            ////InputInt(array);
            ////Console.WriteLine("check number 5: " );
            ////check(array);
            ////Console.WriteLine("check number 5 or 6: ");
            ////check2(array);
            ////Console.WriteLine("check number 5 and 6: ");
            ////check3(array);
            ////Console.WriteLine("have {0} number 5. ", count(array));
            ////Console.WriteLine("have {0} number 5&6.", count2(array));
            ////Console.WriteLine("{0} is sum of all number.", sum(array));

            //draw
            int number = Convert.ToInt32(Console.ReadLine());
            Vertical(4, 'i'); Console.WriteLine();
            rePymid2(number, 'v');
            rePymid(number, 'v');                                      

            Draw
            
        }
        public static void InputInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }
        public static bool IsConstraint5(int[] array)
        {
            int num = 5;
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static void check(int[] array)
        {
            IsConstraint5(array);
            if (IsConstraint5(array) == true)
            {
                Console.WriteLine("number exist");
            }
            else
            {
                Console.WriteLine("number doesnt exist");
            }
        }
        public static bool IsConstraint5or6(int[] array)
        {
            int num = 5; int num2 = 6;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num || array[i] == num2)
                {
                    return true;
                }
            }
            return false;
        }
        public static void check2(int[] array)
        {
            if (IsConstraint5or6(array) == true)
            {
                Console.WriteLine("have number 5 or 6");
            }
            else
            {
                Console.WriteLine("dont have number 5 or 6");
            }
        }
        public static bool IsConstraint5and6(int[] array)
        {
            int num = 5; int num2 = 6;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num && array[i] == num2)
                {
                    return true;
                }
            }
            return false;
          
        }
        public static void check3(int[] array)
        {
            if (IsConstraint5and6(array) == true)
            {
                Console.WriteLine("have 5 and 6");
            }
            else
            {
                Console.WriteLine("dont have 5 and 6");
            }
        }
        public static int count(int[] array)
        {
            int num = 5; int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    count++;
                }
            }
            return count++;
        }
        public static int count2(int[] array)
        {
            int num = 5; int num2 = 6; int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num || array[i] == num2)
                {
                    count2++;
                }
            }
            return count2++;
        }
        public static int sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static void Vertical(int number, char a)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(a);
            }
        }
        static void Horizone(int number, char a)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(a);
            }
        }
        static void rePymid(int number, char a)
        {
           
            Vertical(number * 2 - 1, a);
            Console.WriteLine();
            
            int space = number + number / 2 + 1;
            for (int i = number - 1; i > 1; i--)
            {
                Horizone(number - i,' ');
                Horizone(1, a);
                space = space - 2;
                Horizone(space,' ');
                Horizone(1, a);
                Console.WriteLine();
            }
            Horizone(number - 1,' ');
            Horizone(1, a);
            Console.WriteLine();
        }
        static void rePymid2(int number, char a)
        {
            Horizone(number * 2 - 1, a);
            Console.WriteLine();
            int space = number + number / 2 - 1;
            for (int i = number - 1; i < 1; i++)
            {
                Horizone(number - i,' ');
                Horizone(1, a);
                space = space - 2;
                Horizone(space,' ');
                Horizone(1,a);
                Console.WriteLine();
            }
            Horizone(number - 1, ' ');
            Horizone(1, a);
            Console.WriteLine();
        }
    }
}
