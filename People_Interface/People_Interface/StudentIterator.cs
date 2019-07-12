using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class StudentIterator : IEnumerator
    {
        private IContainer _cont;
        private int _pos = -1;

        public StudentIterator(IContainer cont)
        {
            _cont = cont;
        }

        public object Current
        {
            get
            {
                return _cont[_pos];
            }
        }

        public bool MoveNext()
        {
            _pos++;

            return _pos < _cont.Lenght;
        }

        public void Reset()
        {
            _pos = -1;
        }
    }
}
