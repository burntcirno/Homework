using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100;
            bool[] composite = new bool[N+1];

            for (int num = 2; num <= N/2; num++)
            {
                if (composite[num]) continue;
                for(int num2 = num+1; num2 <= N; num2++)
                {
                    composite[num2] |= (num2 % num == 0); 
                }
            }
           
            for(int num = 2; num < N+1; num++)
            {
                if (!composite[num])
                {
                    Console.Write($"\t{num}");
                }
            }

        }
    }
}
