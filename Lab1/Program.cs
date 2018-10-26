using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();

            int count;
            for (count=0; count<=9; count++)
            {
                //Random rnd = new Random();
                nums[count] = rnd.Next();
                //nums[count] = rnd.Next(10);
                //nums[count] = rnd.Next(3,10);
            }
        }
    }
}
