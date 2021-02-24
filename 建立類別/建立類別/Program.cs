using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJU //命名空間FJU
{
    class NoteBook
    {

    }
}

namespace THU //命名空間THU
{
    class NoteBook
    {

    }
}

namespace 建立類別
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建立新類別");
            FJU.NoteBook A = new FJU.NoteBook();
            THU.NoteBook B = new THU.NoteBook();
            Console.WriteLine("物件建立完成");
            Console.Read();
        }
    }
}
