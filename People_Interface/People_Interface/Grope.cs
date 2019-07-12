using System;
using System.Collections;


namespace People_Interface
{
    class Grope : IContainer, ICloneable
    {
        private Student[] _student;

        public int Lenght
        {
            get
            {
                return _student.Length;
            }
            private set
            {

            }

        }


       

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < _student.Length)
                {
                    return (Student)_student[index].Clone();
                }
                return null;

            }
            set
            {
                if (index > 0 && index < _student.Length)
                {
                    _student[index] = (Student)((Student)value).Clone();

                }
            }
        }

        public object Clone()
        {
            return new Grope(this);
        }

        public IEnumerator GetEnumerator()
        {
            return new StudentIterator(this);
        }


        public Grope(params Student[] st)
        {
            _student = new Student[st.Length];

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] is GoodStudent)
                {
                    _student[i] = (GoodStudent)st[i].Clone();
                    continue;
                }
                if (st[i] is BadStudent)
                {
                    _student[i] = (BadStudent)st[i].Clone();
                    continue;
                }
            }
        }

        public Grope(Grope g)
        {
            _student = new Student[g.Lenght];
            int pos = -1;
            foreach (Student item in g) //// Просто так :)
            {
                ++pos; //// Просто так :)

                if (item is GoodStudent) //// Просто так :)
                {
                    _student[pos] = (GoodStudent)item.Clone();
                    continue;
                }
                _student[pos] = (BadStudent)item.Clone();
            }

        }

    }
}
