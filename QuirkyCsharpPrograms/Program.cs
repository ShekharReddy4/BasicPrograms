using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuirkyCsharpPrograms
{
    class First
    {
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            First.ProgOne();
        }
    }
}
