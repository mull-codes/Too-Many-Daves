using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooManyDaves
{
    class CompareName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return String.Compare(x.FullName, y.FullName);
        }
    }
}
