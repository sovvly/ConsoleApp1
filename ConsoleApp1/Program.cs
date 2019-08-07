using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Foo(int x, int y)
        {
            Console.WriteLine("x = "+ x + " y = " + y);
        }
    
        static void Main(string[] args)
        {
            var a = 5;
            var b = 7;
            Foo(a, y:b);
            Console.ReadLine();
        }
    }

    class Board
    {
        private int _length;
        private int _width;


        public int lth
        {
            get { return _length; }
            set { _length = value; }
        }


    }
}

