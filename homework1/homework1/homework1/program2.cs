using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个整数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个整数：");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a + b：" + (a + b).ToString());
            Console.WriteLine("a * b：" + (a * b).ToString());

        }
    }
}
