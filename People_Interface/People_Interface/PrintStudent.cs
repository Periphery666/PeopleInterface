using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class PrintStudent
    {

        public static void Print (IContainer cont)
        {
            foreach (Student item in cont)
            {
                Console.WriteLine(item);

                foreach (bool bitem in item)
                {
                    Console.WriteLine(bitem);
                }
            }


        }


    }
}
