using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGKPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Abs(-5));
            // not exaclty implemented but partly should be trying later
            for (int i = 0; i < n / 2 + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= (n / 2) - i)
                    {
                        Console.Write((char)('A' + i + j) + " ");
                    }
                    else if (j > n / 2 + i)
                    {
                        Console.Write((char)('A' + n - i - j) + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
