using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_overloading
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("It is a Default Constructor!!");
        }
        public Program(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public Program(string a, string b)
        {
            Console.WriteLine("This is third Constructor !!{0}  {1}", a, b);
        }

        static void Main(string[] args)
        {
            //Program p = new Program();
           // Program p1 = new Program(20,30); 
            Program p2 = new Program("Priya", "Shweta");

            Console.ReadLine();

        }
    }
}

