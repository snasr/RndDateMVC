using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();

            for (int counter = 0; counter <=9; counter++)
            {
                nums[counter] = rnd.Next(11);
            }

            foreach (int num in nums)
                Console.WriteLine(num);
        }


    }
}
