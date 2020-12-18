using System;

namespace NumberPatterns
{
    class Program
    {
        /*
        A
        AB
        ABC
        ABCD
        ABCDE
        */
        public static void Pat1()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        E
        DE
        CDE
        BCDE
        ABCDE
         */
        public static void Pat2()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        A
        BA
        CBA
        DCBA
        EDCBA
        */
        public static void Pat3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        E
        ED
        EDC
        EDCB
        EDCBA
        */
        public static void Pat4()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        ABCDE
        ABCD
        ABC
        AB
        A
         */
        public static void Pat5()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i + 1; j++)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        ABCDE
        BCDE
        CDE
        DE
        E
         */
        public static void Pat6()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        /*
        EDCBA
        DCBA
        CBA
        BA
        A
         */
        public static void Pat7()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)('A' + i - j));
                }
                Console.WriteLine();
            }
        }

        /*
        EDCBA
        EDCB
        EDC
        ED
        E
         */
        public static void Pat8()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write((char)('A' + j - 1));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Pat1();
            Console.WriteLine();

            Pat2();
            Console.WriteLine();

            Pat3();
            Console.WriteLine();

            Pat4();
            Console.WriteLine();

            Pat5();
            Console.WriteLine();

            Pat6();
            Console.WriteLine();

            Pat7();
            Console.WriteLine();

            Pat8();
            Console.WriteLine();


        }
    }
}
