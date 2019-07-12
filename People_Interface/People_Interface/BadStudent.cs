using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class BadStudent : Student, IContainer
    {
        bool _retake;


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2} ,", _firstName, _lastName, _retake);
        }

        public override object Clone()
        {
            return new BadStudent(_retake, _sex, _weight, _firstName, _lastName, _exam);
        }

        public BadStudent(bool retake, Sex sex, uint weight, string firstName, string lastName, bool[] exam) : base(sex, weight, firstName, lastName, exam)
        {
            _retake = retake;
        }


    }
}
