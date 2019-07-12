using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Grope g = new Grope(new GoodStudent(true, Sex.Male, 187, "Sanya", "Pupkin", new bool[] { true, true,true})
                                , new BadStudent(false, Sex.Female, 145,"Katya", "Kakashkina", new bool[]  {false, false, false }));




            PrintStudent.Print(g);

            //foreach (Student item in g)
            //{
            //    foreach (bool bitem in item)
            //    {
            //        Console.WriteLine(bitem);
            //    }

            //}


           
        }
    }
}
