using System;

namespace InrythmCodingInterview
{
    class Solution
    {
        // Q 1 Intresting number problem
        public void solution(int N, int[] k)
        {
            // sort the array
            int temp;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (k[i] > k[j])
                    {
                        temp = k[j];
                        k[j] = k[i];
                        k[i] = temp;
                    }
                }
            }
            int lcount = 1;
            int current_count = 1;

            for (int i = 0; i < N - 1; i++)
            {
                if (k[i] + 1 == k[i + 1])
                {
                    current_count++;
                }
                else if (k[i] == k[i + 1])
                {
                    continue;
                }
                else
                {
                    if (lcount < current_count)
                    {
                        lcount = current_count;
                    }

                    current_count = 1;
                }
            }
            if (lcount < current_count)
            {
                lcount = current_count;
            }
            Console.WriteLine(lcount);
        }

        // Q 2 Boys and Girls are standing in a row how many are standing together

        public void solution2(int b, int g)
        {
            if (b == g)
            {
                Console.WriteLine(0);
            }
            else
            {
                int res = Math.Max(b, g) - Math.Min(b, g) - 1;
                Console.WriteLine(res);
            }
        }

    }

    // Following is the part of the program and is provided as an assistance to read the input.
    public class cgProgram
    {
        public static void Main()
        {

            Solution s = new Solution();

            // Q 1 input reading through console

            int N = Convert.ToInt32(Console.ReadLine());
            string[] Ks = Console.ReadLine().Split(null);
            int[] K = new int[N];
            for (int j = 0; j < N; j++)
                K[j] = Convert.ToInt32(Ks[j]);
            s.solution(N, K);


            // Q 2 input reading through console

            int B = Convert.ToInt32(Console.ReadLine());
            int G = Convert.ToInt32(Console.ReadLine());

            s.solution2(B, G);

        }
    }
}
