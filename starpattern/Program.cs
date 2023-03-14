using System;
namespace starpattern
{
    class Program
    {
        public static void Starpattern01()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Starpattern02()
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Starpattern03()
        {
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Starpattern04()
        {
            int i, j, k;
            int space = 0;

            for (i = 5; i > 0; i--)
            {

                for (k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
                space++;
            }
        }

        public static void Starpattern05()
        {
            int i, j, k;
            int space = 0;

            for (i = 5; i > 0; i--)
            {

                for (k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                for (j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
                space++;
            }
        }

        public static void Starpattern06()
        {
            int i, j, space = 1;
            space = 5;
            for (j = 1; j <= 5; j++)
            {
                for (i = 1; i <= space; i++)
                    Console.Write(" ");
                space--;

                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Starpattern07()
        {
            int count = 1;

            do
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                count++;
            } while (count < 6);

        }

        public static void Starpattern08()
        {
            int i = 1, j, k;
            do
            {
                for (j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i++;
            } while (i < 6);
        }

        public static void Starpattern09()
        {
            int i = 5, j;
            do
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i--;
            } while (i >= 1);
        }

        public static void Starpattern10()
        {
            int i = 5, j, k;
            int space = 0;

            do
            {

                for (k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
                space++;
                i--;
            } while (i > 0);
        }

        public static void Starpattern11()
        {
            int i = 5, j, k;
            int space = 0;

            do
            {

                for (k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                for (j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
                space++;
                i--;
            } while (i > 0);
        }

        public static void Starpattern12()
        {
            int i, j = 1, space = 1;
            space = 5;
            do
            {
                for (i = 1; i <= space; i++)
                    Console.Write(" ");
                space--;

                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
                j++;
            } while (j <= 5);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Starpattern01();
            Starpattern02();
            Starpattern03();
            Starpattern04();
            Starpattern05();
            Starpattern06();
            Starpattern07();
            Starpattern08();
            Starpattern09();
            Starpattern10();
            Starpattern11();
            Starpattern12();
        }
    }
}