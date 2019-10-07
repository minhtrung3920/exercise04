using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            draw(number, 'i');
            Console.WriteLine();
            draw1(number, 'o');
            Console.WriteLine();
            draw2(number, 'u');
            Console.WriteLine();
            draw3(number, 'v');
            Console.WriteLine();
            draw4(number, 'x');
            Console.WriteLine();
            draw5(number, '+');
            Console.WriteLine();
            draw6(number, 'v');
            Console.WriteLine();
            draw7(number, 'V');
            Console.WriteLine();
            draw8(number, '^');
            Console.WriteLine();
            draw9(number, 'A');

        }
        public static void line(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        public static void square(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < number; j++)
                {
                    Console.Write(c);
                }
            }
        }
        public static void Horizone(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        public static void draw(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        public static void draw1(int number, char c)
        {
            int space;
            //line1
            Horizone(number, c); Console.WriteLine();
            //line i
            for (int i = 0; i < number - 2; i++)
            {
                Horizone(1, c); Horizone(number - 2, ' '); Horizone(1, c); Console.WriteLine();
            }
            //last line;
            Horizone(number, c); Console.WriteLine();
        }
        public static void draw2(int number, char c)
        {
            //i-line           
            for (int i = 0; i < number - 1; i++)
            {
                Horizone(1, c); Horizone(number - 2, ' '); Horizone(1, c); Console.WriteLine();
            }
            //last-line
            Horizone(number, c); Console.WriteLine();
        }
        public static void draw3(int number, char c)
        {
            //draw W
            //1-line
            //int space1 = number + 1;
            Horizone(1, c); Horizone(number + 1, ' '); Horizone(1, c); Horizone(number + 1, ' '); Horizone(1, c); Console.WriteLine();
            //i-line
            int space2 = number + 1;
            int space3 = 1;
            for (int i = 1; i <= number / 2; i++)
            {
                space2 = space2 - 2;
                Horizone(i, ' '); Horizone(1, c); Horizone(space2, ' '); Horizone(1, c); Horizone(space3, ' ');
                Horizone(1, c); Horizone(space2, ' '); Horizone(1, c); Console.WriteLine();
                space3 = space3 + 2;
                //last line - check lai de hieu
                if (i == number / 2)
                {
                    Horizone(i + 1, ' '); Horizone(1, c); Horizone(number * 2 - i * 2 + 1, ' '); Horizone(1, c);
                }
            }



        }
        public static void draw4(int number, char c)
        {
            int topspace2 = number - 1;
            int topspace1 = 0;
            //draw X
            //top mid line
            for (int i = 0; i < number / 2; i++)
            {

                Horizone(topspace1, ' '); Horizone(1, c); Horizone(topspace2, ' '); Horizone(1, c); Console.WriteLine();
                topspace1 = topspace1 + 1;
                topspace2 = topspace2 - 2;
            }

            //mid-line
            Horizone(number / 2, ' '); Horizone(1, c); Console.WriteLine();
            //bot mid line
            int botspace1 = number / 2 - 1;
            int botspace2 = 1;
            for (int i = 0; i < number / 2; i++)
            {

                Horizone(botspace1, ' '); Horizone(1, c); Horizone(botspace2, ' '); Horizone(1, c); Console.WriteLine();
                botspace1 = botspace1 - 1;
                botspace2 = botspace2 + 2;
            }
        }
        public static void draw5(int number, char c)
        {
            //top-mid
            for (int i = 0; i < number / 2; i++)
            {
                Horizone(number / 2, ' '); Horizone(1, c); Console.WriteLine();
            }
            //middle
            Horizone(number + 1, c); Console.WriteLine();
            //bot-mid
            for (int i = 0; i < number / 2; i++)
            {
                Horizone(number / 2, ' '); Horizone(1, c); Console.WriteLine();
            }
        }
        public static void draw6(int number, char c)
        {
            int topspace2 = number * 2 - 2;
            int topspace1 = 1;
            //draw X
            //top mid line
            for (int i = 0; i < number; i++)
            {

                Horizone(topspace1, ' '); Horizone(1, c); Horizone(topspace2 + 1, ' '); Horizone(1, c); Console.WriteLine();
                topspace1 = topspace1 + 1;
                topspace2 = topspace2 - 2;
            }
            Horizone(number + 1, ' '); Horizone(1, c); Console.WriteLine();
        }
        static void draw7(int number, char c)
        {
            Horizone(number * 2 + 3, c); Console.WriteLine();
            int topspace2 = number * 2 - 2;
            int topspace1 = 1;
            //draw X
            //top mid line
            for (int i = 0; i < number; i++)
            {

                Horizone(topspace1, ' '); Horizone(1, c); Horizone(topspace2 + 1, ' '); Horizone(1, c); Console.WriteLine();
                topspace1 = topspace1 + 1;
                topspace2 = topspace2 - 2;
            }
            Horizone(number + 1, ' '); Horizone(1, c); Console.WriteLine();
        }
        static void draw8(int number, char c)
        {
            // line 1 : n-1 space / 1 star
            // line 2 : n-2 space/ 1 star, 1 space/1 star
            // line 3 : n-3 space/ 1 star, 3 space/1 star
            // last line 2n-1 star 
            {
                //first line
                Horizone(number - 1, ' '); Horizone(1, c); Console.WriteLine();
                // i-th line           
                int line = 1, space = number + 1;
                for (int i = 1; i < number; i++)
                {
                    line = line + 1;
                    Horizone(number - line, ' '); Horizone(1, c);
                    // we got space = number+1 - 2, because Value (number - space) must grow 2 time/ 1 it's only a oDD 
                    space = space - 2;
                    Horizone(number - space, ' '); Horizone(1, c); Console.WriteLine();
                }
                // last line
                Horizone(number * 2 - 1, c);
            }
        }
        static void draw9(int number, char c)
        {
            // line 1 : n-1 space / 1 star
            // line 2 : n-2 space/ 1 star, 1 space/1 star
            // line 3 : n-3 space/ 1 star, 3 space/1 star
            // last line 2n-1 star 
            {
                Horizone(number * 2 - 1, ' '); Horizone(1, c); Console.WriteLine();
                //bot mid line
                int botspace1 = number * 2 - 2;
                int botspace2 = 1;
                for (int i = 0; i < number; i++)
                {
                    if (i == number / 2)
                    {
                        Horizone(botspace1, ' '); Horizone(1, c); Horizone(botspace2, c); Horizone(1, c); Console.WriteLine();
                        botspace1 = botspace1 - 1;
                        botspace2 = botspace2 + 2;
                    }
                    Horizone(botspace1, ' '); Horizone(1, c); Horizone(botspace2, ' '); Horizone(1, c); Console.WriteLine();
                    botspace1 = botspace1 - 1;
                    botspace2 = botspace2 + 2;
                }
            }
        }
    }
}
