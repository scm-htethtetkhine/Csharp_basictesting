using System;

namespace Array
{
    class Program
    {
        // two-dimensional Array
        public static void Int2DArray()
        {
            int[,] numbers = new int[5, 2] {
          {3,1} , {6,2} , {9,3} , {4,2} , {8,4}
        };
            Console.WriteLine(numbers[0, 0]);
            Console.WriteLine(numbers[0, 1]);
            Console.WriteLine(numbers[1, 0]);
            Console.WriteLine(numbers[1, 1]);
            Console.WriteLine(numbers[2, 0]);
            Console.WriteLine(numbers[2, 1]);
            Console.WriteLine(numbers[3, 0]);
            Console.WriteLine(numbers[3, 1]);
            Console.WriteLine(numbers[4, 0]);
            Console.WriteLine(numbers[4, 1]);
        }

        // three-dimensional Array
        public static void Int3DArray()
        {
            int[,,] numbers = new int[2, 2, 3] {
           { { 1, 2, 3}, {4, 5, 6} },
           { { 7, 8, 9}, {10, 11, 12} }
           };

            Console.WriteLine(numbers[0, 0, 0]);
            Console.WriteLine(numbers[0, 0, 1]);
            Console.WriteLine(numbers[0, 0, 2]);
            Console.WriteLine(numbers[0, 1, 0]);
            Console.WriteLine(numbers[0, 1, 1]);
            Console.WriteLine(numbers[0, 1, 2]);
            Console.WriteLine(numbers[1, 0, 0]);
            Console.WriteLine(numbers[1, 0, 1]);
            Console.WriteLine(numbers[0, 1, 2]);
            Console.WriteLine(numbers[1, 1, 0]);
            Console.WriteLine(numbers[1, 1, 1]);
            Console.WriteLine(numbers[1, 1, 2]);
        }

        // four-dimensional Array
        public static void Int4DArray()
        {
            int[,,,] numbers = new int[1, 2, 2, 2] {
           {
            { {1,2} , {3,4}} ,
            { {5,6} , {7,8}}
           }
          };
            Console.WriteLine(numbers[0, 0, 0, 0]);
            Console.WriteLine(numbers[0, 0, 0, 1]);
            Console.WriteLine(numbers[0, 0, 1, 0]);
            Console.WriteLine(numbers[0, 0, 1, 1]);
            Console.WriteLine(numbers[0, 1, 0, 0]);
            Console.WriteLine(numbers[0, 1, 0, 1]);
            Console.WriteLine(numbers[0, 1, 1, 0]);
            Console.WriteLine(numbers[0, 1, 1, 1]);
        }

        // five-dimensional Array
        public static void Int5DArray(int a, int b, int c, int d, int e)
        {
            int ind1 = 0;
            int ind2 = 0;
            int ind3 = 0;
            int ind4 = 0;
            int ind5 = 0;
            int[,,,,] numbers = new int[1, 2, 2, 2, 3] {
           {
            {{ {1,2,3} , {4,5,6}} ,
            {{7,8,9} , {10,11,12} }},
            {{ {13,14,15} , {16,17,18}} ,
            {{19,20,21} , {22,23,24} }}
           }
         };
            if (numbers.GetLength(0) < 2)
            {
                ind1 = a;
            }
            if (numbers.GetLength(1) < 3)
            {
                ind2 = b;
            }
            if (numbers.GetLength(2) < 3)
            {
                ind3 = c;
            }
            if (numbers.GetLength(3) < 3)
            {
                ind4 = d;
            }
            if (numbers.GetLength(4) < 4)
            {
                ind5 = e;
            }
            Console.WriteLine(numbers[ind1, ind2, ind3, ind4, ind5]);


            // Console.WriteLine(numbers[0, 0, 0, 0, 0]);
            // Console.WriteLine(numbers[0, 0, 0, 0, 1]);
            // Console.WriteLine(numbers[0, 0, 0, 0, 2]);
            // Console.WriteLine(numbers[0, 0, 0, 1, 0]);
            // Console.WriteLine(numbers[0, 0, 0, 1, 1]);
            // Console.WriteLine(numbers[0, 0, 0, 1, 2]);
            // Console.WriteLine(numbers[0, 0, 1, 0, 0]);
            // Console.WriteLine(numbers[0, 0, 1, 0, 1]);
            // Console.WriteLine(numbers[0, 0, 1, 0, 2]);
            // Console.WriteLine(numbers[0, 0, 1, 1, 0]);
            // Console.WriteLine(numbers[0, 0, 1, 1, 1]);
            // Console.WriteLine(numbers[0, 0, 1, 1, 2]);
            // Console.WriteLine(numbers[0, 1, 0, 0, 0]);
            // Console.WriteLine(numbers[0, 1, 0, 0, 1]);
            // Console.WriteLine(numbers[0, 1, 0, 0, 2]);
            // Console.WriteLine(numbers[0, 1, 0, 1, 0]);
            // Console.WriteLine(numbers[0, 1, 0, 1, 1]);
            // Console.WriteLine(numbers[0, 1, 0, 1, 2]);
            // Console.WriteLine(numbers[0, 1, 1, 0, 0]);
            // Console.WriteLine(numbers[0, 1, 1, 0, 1]);
            // Console.WriteLine(numbers[0, 1, 1, 0, 2]);
            // Console.WriteLine(numbers[0, 1, 1, 1, 0]);
            // Console.WriteLine(numbers[0, 1, 1, 1, 1]);
            // Console.WriteLine(numbers[0, 1, 1, 1, 2]);
        }

        // foreach loop in Arrays

        public static void ForloopArray()
        {
            int[,,,,] numbers = new int[1, 2, 2, 2, 3] {
           {
            {{ {1,2,3} , {4,5,6}} ,
            {{7,8,9} , {10,11,12} }},
            {{ {13,14,15} , {16,17,18}} ,
            {{19,20,21} , {22,23,24} }}
           }
         };

            // foreach loop in Array
            Console.WriteLine("Foreach Loop \n============");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // for loop in Array
            Console.WriteLine("For Loop \n=============");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(2); k++)
                    {
                        for (int m = 0; m < numbers.GetLength(3); m++)
                        {
                            for (int n = 0; n < numbers.GetLength(4); n++)
                            {
                                Console.WriteLine(numbers[i, j, k, m, n]);
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 }, { 7, 0, 9 } };
            // Console.WriteLine(numbers.Length);
            // Console.WriteLine(numbers[1, 2]);
            Int2DArray();
            Int3DArray();
            Int4DArray();
            Int5DArray(0, 0, 1, 1, 1);
            Int5DArray(0, 1, 1, 1, 2);
            ForloopArray();
        }
    }
}