using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginateCodingProg
{
    class MainClass
    {
        public static string sol(string mstr, string sstr)
        {
            mstr = mstr.ToUpper();
            sstr = sstr.ToUpper();
            string res = "";
            int i = 0;
            for (; i < mstr.Length; i++)
            {
                if (mstr[i] == sstr[0])
                {
                    int j = 1;
                    for (; j < sstr.Length; j++)
                    {
                        if ((i + j <= mstr.Length - 1) && mstr[i + j] == sstr[j])
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (j == sstr.Length)
                    {
                        res = res.Length == 0 ? "" + i : res + ", " + i;
                    }
                }
            }
            return res;
        }
        public static void Main(string[] args)
        {
            string mstr = Console.ReadLine();
            string sstr = Console.ReadLine();
            string res = sol(mstr, sstr);

            if (res.Length == 0)
            {
                Console.WriteLine("Not a substring");
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
