using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            InputInt(array);
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
            return true;

        }
    }
}
