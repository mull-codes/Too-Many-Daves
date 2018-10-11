using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooManyDaves
{
    class Person
    {
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Likes { get; set; }

        public Person()
        {
            this.FullName = "";
            this.DOB = new DateTime();
            this.Likes = "";
        }

        public Person(string fullName, DateTime dob, string likes)
        {
            this.FullName = fullName;
            this.DOB = dob;
            this.Likes = likes;
        }

        public Person(string name)
        {
            this.FullName = name;
            this.DOB = new DateTime();
            this.Likes = "";
        }

        public Person(string name, DateTime dob)
        {
            this.FullName = name;
            this.DOB = dob;
            this.Likes = "";
        }


        public void SetName(string name)
        {
            this.FullName = name;
        }

        public void SetDOB(DateTime dob)
        {
            this.DOB = dob;
        }

        public void SetLikes(string likes)
        {
            this.Likes = likes;
        }

        public bool HasSpecialChar()
        {
            if (this.FullName.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SearchByDOB(DateTime dob)
        {
            if (dob == this.DOB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SearchByName(string name)
        {
            if (this.FullName.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SearchByLike(string like)
        {
            if (this.Likes.Contains(like))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string GetName()
        {
            return this.FullName;
        }

        public DateTime GetDOB()
        {
            return this.DOB;
        }

        public string GetLikes()
        {
            return this.Likes;
        }

        public string Display()
        {
            return String.Format("Full Name:{0, 30} \tD.O.B:{1,20} \tLikes:{2}", this.FullName, this.DOB, this.Likes);
        }


        //public int CompareTo(object obj)
        //{
        //    if (obj is Person)
        //    {
        //        Person s = obj as Person;
        //        //return (string.Compare(this.FirstName, s.FirstName));
        //        return (DateTime.Compare(this.DOB, s.DOB));
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Object to compare is not a Student object");
        //    }
        //}
    }
}

