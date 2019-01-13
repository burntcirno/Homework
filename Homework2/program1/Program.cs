using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please input a number:");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("the prime factors are:");
                for (int factor = 2; factor * factor <= num;factor++)
                {
                    while (num % factor == 0)
                    {
                        Console.Write("\t" + factor);
                        num = num / factor; 
                    }
                }
                if (num != 1) 
                {
                    Console.Write("\t" + num);
                }
            }
            catch
            {
                Console.WriteLine("error input!");
            }
        }
    }
}
