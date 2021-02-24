using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建立方法
{
    class Car
    {
        private int _speed = 0;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if(value < 0)
                {
                    value = 0;
                }
                if(value >200)
                {
                    value = 200;
                }
                _speed = value;
            }
        }

        public void Accelerate()
        {
            this.Speed++;
        }

        public void Accelerate(int addSpeed)
        {
            this.Speed += addSpeed;
        }

        public void Accelerate(string S)
        {
            if(S == "STOP")
            {
                this.Speed = 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Benz = new Car();
            Console.WriteLine("現在速度: {0}", Benz.Speed);
            Benz.Accelerate();
            Console.WriteLine("第一次加速: {0}", Benz.Speed);
            Benz.Accelerate(10);
            Console.WriteLine("第二次加速: {0}", Benz.Speed);
            Benz.Accelerate("STOP");
            Console.WriteLine("停車後速度: {0}", Benz.Speed);
            Console.Read();
        }
    }
}
