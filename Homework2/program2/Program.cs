using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = {2.1,3,0,5.2,10,90,102,4.6,2,0 };
            double max = nums[0];
            double min = nums[0];
            double sum = 0;
            foreach (double n in nums)
            {
                max = (n > max) ? n:max;
                min = (n < min) ? n:min;
                sum += n;
            }
            double average = sum / nums.Length;
            Console.WriteLine($"min={min},max={max},sum={sum},average={average}");
        }
    }
}
