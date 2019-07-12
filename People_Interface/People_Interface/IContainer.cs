using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    interface IContainer: IEnumerable
    {
        int Lenght { get; }
        object this[int index] { get; set; }
    }

}
