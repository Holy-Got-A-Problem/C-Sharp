using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 在方法間傳遞陣列
{
    class Program
    {
        private static int GetMax(ref int[] ary)
        {
            int max = ary[0];
            for(int i = 1; i<= ary.GetUpperBound(0); i++)
            {
                if (max < ary[i])
                {
                    max = ary[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] tAry = new int[] {12,15,38,21,25};
            Console.WriteLine("陣列元素:");
            for(int i=0; i<= tAry.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}", tAry[i]);
            }
            Console.WriteLine();
            Console.WriteLine("陣列最大值:{0}",GetMax(ref tAry));
            Console.Read();
        }
    }
}
