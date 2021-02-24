using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引數傳遞呼叫
{
    class Program
    {
        private static void CallValue(ref int x, ref int y)
        {
            int z;
            x = 50;
            y = 60;
            Console.WriteLine("傳值前 : x = {0},y = {1}",x,y);
            z = x;
            x = y;
            y = z;
            Console.WriteLine("傳值後 : x =  {0},y = {1}", x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n 傳值呼叫 \n");
            
            int a = 90;
            int b = 80;
            Console.WriteLine("呼叫敘述前: x = {0},y = {1}", a, b);
            CallValue(ref a, ref b);
            Console.WriteLine("呼叫敘述後: x = {0},y = {1}", a, b);
            Console.Read();
        }
    }
}
