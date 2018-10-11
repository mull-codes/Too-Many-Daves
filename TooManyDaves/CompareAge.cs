using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooManyDaves
{
    class CompareAge : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return DateTime.Compare(p1.DOB, p2.DOB);
        }
    }
}
