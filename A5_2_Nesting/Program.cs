using System;

namespace A5_2_Nesting
{
    class Program
    {
        static void Main()
        {
            string a = "*";
            string s = " ";
            Console.WriteLine(s);
            for (int complete = 1; complete <=1; complete++)
            {
                for (int top = 1; top <= 4; top++)
                {
                    Console.Write(s);
                }
                Console.Write($"{a}\n");
                for (int secs = 1; secs <=3; secs++)
                {
                    Console.Write(s);
                }
                for (int seca = 1; seca <= 3; seca++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
                for (int thirs = 1; thirs <=2; thirs++)
                {
                    Console.Write(s);
                }
                for (int thira = 1; thira <=5; thira++)
                {
                    Console.Write(a);
                }
                Console.Write("\n ");
                for (int foura = 1; foura <=7; foura++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
                for (int fith = 1; fith <= 9; fith++)
                {
                    Console.Write(a);
                }
                Console.Write("\n ");
                for (int foura = 1; foura <= 7; foura++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
                for (int thirs = 1; thirs <= 2; thirs++)
                {
                    Console.Write(s);
                }
                for (int thira = 1; thira <= 5; thira++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
                for (int secs = 1; secs <= 3; secs++)
                {
                    Console.Write(s);
                }
                for (int seca = 1; seca <= 3; seca++)
                {
                    Console.Write(a);
                }
                Console.Write("\n");
                for (int top = 1; top <= 4; top++)
                {
                    Console.Write(s);
                }
                Console.Write(a);
            }

           
        }
    }
}
/*


    *      4 spaces 1 astrisk      
   ***     3 spaces 3 astrisk
  *****    2 spaces 5 astrisk
 *******   1 spaces 7 astrisk
*********  0 spaces 9 astrisk
 *******
  *****
   ***
    *

*/