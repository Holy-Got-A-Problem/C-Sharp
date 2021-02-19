using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 程式練習簿
{
    class theClass
    {
        public string Test(string name, bool ismale, bool isfemale)
        {
            string str = " ";
            if (ismale)
            {
                str = name + "男士測試成功";
            }
            else if (isfemale)
            {
                str = name + "女士測試成功";
            }
            else
            {
                str = name + "跨性別測試成功";
            }
            return str;


        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("請輸入您的名字: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            theClass myClass = new theClass();
            string checkRight = myClass.Test(name, true, false);
            Console.WriteLine("{0}",checkRight);
            Console.WriteLine();
            Console.WriteLine("{0}",myClass.Test(name,false,true));
            Console.WriteLine("{0}", myClass.Test(name, false, false));

            Console.Read();
        }
    }
}
