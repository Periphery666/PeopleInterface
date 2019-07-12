using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{


    abstract class Base 
    {
        //public abstract void F();
    }


    class Child1 :Base
    {
        public int x = 2;

        public /*override*/ void F()
        {
            Console.WriteLine(x);
        }

        public Child1()
        {

        }

        public Child1(int xx )
        {
            x = xx;
        }
    }


    class Child2 : Base
    {

       public  int x = 2;
        public /*override*/ void F ()
        {
            Console.WriteLine(x);
        }

    }


    class MyClass
    {
        public Base b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.b = new Child1(666);

            ((Child1)m.b).F();
           

        }
    }
}
