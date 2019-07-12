using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    class GoodStudent : Student, IContainer
    {
        bool _grant { get; set; }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2} ,", _firstName, _lastName, _grant);
        }

        public GoodStudent(bool grant, Sex sex, uint weight, string firstName, string lastName, bool[] exam) : base(sex, weight, firstName, lastName, exam)
        {
            _grant = grant;
        }

        public override object Clone()
        {
            return new GoodStudent(_grant, _sex, _weight, _firstName, _lastName, _exam);
        }

    }
}
