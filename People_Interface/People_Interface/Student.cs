using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class Student : Human, ICloneable, IEnumerable, IContainer
    {

        protected bool[] _exam;

        public virtual int Lenght
        {
            get
            {
                return -1;
            }
        }


        public  override string ToString()
        {
            return base.ToString();
        }
        public virtual object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual object Clone()
        {
            return new Student(this);
        }

        public IEnumerator GetEnumerator()
        {
            return _exam.GetEnumerator();
        }





        public Student(Student st) : base(st._sex, st._weight, st._firstName, st._lastName)
        {
            _exam = (bool[])st._exam.Clone();

        }

        public Student(Sex sex, uint weight, string firstName, string lastName, bool[] exam) : base(sex, weight, firstName, lastName)
        {
            _exam = (bool[])exam.Clone();
        }

    }
}
