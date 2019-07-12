using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Interface
{
    abstract class Human
    {
        protected Sex _sex { get; }
        protected uint _weight { get; set; }
        protected string _firstName { get; }
        protected string _lastName { get; set; }



        public Human(Sex sex, uint weight, string firstName, string lastName)
        {
            _sex = sex;
            _weight = weight;
            _firstName = firstName;
            _lastName = lastName;

        }

    }
}
