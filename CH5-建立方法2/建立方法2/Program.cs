using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建立事件
{
    delegate void DangerEvent(int vSpeed);

    class Car
    {
        private int _speed;

        public event DangerEvent Danger;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if(value > 200)
                {
                    if (Danger != null) Danger(value);
                }
                _speed = value;
            }
        }
    }
    class Program
    {
        static void TooFast(int vSpeed)
        {
            Console.WriteLine("目前速度:{0},你已超速", vSpeed);
        }

        static void Main(string[] args)
        {
            Car Benz = new Car();
            Benz.Danger += new DangerEvent(TooFast);
            Benz.Speed = 500;
            Console.Read();

        }
    }
}
