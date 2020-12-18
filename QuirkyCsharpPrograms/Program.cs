using System;
using System.Collections.Generic;

namespace QuirkyCsharpPrograms
{
    class FirstUtilClass
    {
        // Program: 1
        public static void ProgOne()
        {
            int a = 29;
            a--; // 28 
            a -= ++a; // -= operator will do {a = a-(++a)} // x -= y will transform to x = x - y
            Console.WriteLine(a); // -1


            int b = 29;
            b--; // 28 
            b = -++b; // here =- is NOT an operator but an assignment to the LHS and prepend SIGN to the RHS
            Console.WriteLine(b); // -29
        }

        // Program: 2 Delegates in a generic class and calling the anon fucntion stored

        delegate void Printer();
        public static void ProgTwo()
        {
            List<Printer> printers = new List<Printer>();

            int i = 0;

            for (; i < 10; i++)

            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();//print 10
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstUtilClass.ProgOne();
            FirstUtilClass.ProgTwo();
        }
    }
}
