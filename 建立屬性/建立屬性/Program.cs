using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建立屬性
{
    class Car
    {
        private int _speed;

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 200)
                {
                    value = 200;
                }
                _speed = value;
            }

        }
    }

        
    class Program
    {
        static void Main(string[] args)
        {
            Car Benz = new Car();
            Benz.Speed = 500;
            Console.WriteLine("車速 = {0}",Benz.Speed);
            Console.Read();
        }
    }
}
