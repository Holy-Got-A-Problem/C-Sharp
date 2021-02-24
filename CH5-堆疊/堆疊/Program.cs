using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆疊
{
    class Stack
    {
        private int[] _arrayData;  //存放堆疊的陣列
        private int _top;        //堆疊最上方資料(最上方資料在堆疊的位置)

        //【1.建構式】
        public Stack(int n)        //建立可存放n個元素的_arrayData整數陣列
        {
            _arrayData = new int[n];
            _top = 0;   //預設為0，表堆疊底部
        }

        //【2.Push:資料放入堆疊】
        public void Push(int n)
        {
            if(_top == _arrayData.Length)    //當最上方資料與堆疊陣列容量相同時表堆疊已滿
            {
                Console.WriteLine("\n 堆疊滿了！");
                return;
            }
            _arrayData[_top] = n;       //將資料存入_top位置所在的堆疊中(_arrayData[_top]表最上方資料)
            _top += 1;                  //_top位置往上移(以提供下一個資料放入堆疊)
            Console.WriteLine("\n 壓入{0}到堆疊內", n);
        }

        //【3.Pop:資料取出堆疊】
        public void Pop()
        {
            if(_top == 0)
            {
                Console.WriteLine("\n 堆疊已空！");
                return;
            }
            _top -= 1;  //_top位置往下移(空一個空間提供下一個資料存入堆疊)
            Console.WriteLine("\n 將{0}從堆疊彈出",_arrayData[_top]);   //_arrayData[_top]表最上方資料
        }

        //【4.印出堆疊所有資料】
        public void PrintStack()
        {
            if(_top == 0)
            {
                Console.WriteLine("\n 裡面沒有資料!");
                return;
            }
            Console.WriteLine("\n 印出堆疊內容");
            for(int i=0; i<_top; i++)    //從最底到最高堆疊資料通通印出來
            {
                Console.WriteLine("{0}", _arrayData[i]);   //取出陣列元素
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 請輸入堆疊可存放數量: ");
            int num = int.Parse(Console.ReadLine());   //寫入讀取數量
            Stack s = new Stack(num);   //設定一個以Stack為版型的新物件s
            int sel, input;           //變數:選項 & 資料輸入

            do
            {
                //【1.操作介面】
                Console.WriteLine();
                Console.WriteLine("====堆疊操作介面====");
                Console.WriteLine("1.放入堆疊");
                Console.WriteLine("2.拿出堆疊");
                Console.WriteLine("3.印出堆疊");
                Console.WriteLine("4.操作結束");
                Console.WriteLine("====================");
                Console.Write("請選擇以上選項操作:");
                sel = int.Parse(Console.ReadLine());

                //【2.選項動作】
                if(sel == 1)  //Push
                {
                    Console.WriteLine("\n 請輸入要放入堆疊的資料");
                    input = int.Parse(Console.ReadLine());      //input變數即資料
                    s.Push(input);
                }
                else if (sel == 2)  //Pop
                {
                    s.Pop();
                }
                else if (sel == 3)  //Print
                {
                    s.PrintStack();
                }
                else if (sel == 4)  //End
                {
                    Console.WriteLine("\n ====離開系統====");
                    return;
                }
                else   //Wrong Number
                {
                    Console.WriteLine("\n ====請使用正確的號碼====");
                }
            } while (true);

            //Console.ReadLine();
        }
    }
}
