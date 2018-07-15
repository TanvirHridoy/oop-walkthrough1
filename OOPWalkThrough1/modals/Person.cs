using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.modals
{
    class Person
    {
        //private string Firstname = "";
        //private string Middlename = "";
        //private string Lastname = "";
        public Person()
            {
        
            }
        public Person(string firstname):this()
            {
                this.Firstname = firstname;
            }

        public Person(string firstname, string lastname) : this(firstname)
        {
            this.Lastname = lastname;
        }
        public Person(string firstname, string middlename, string lastname):this(firstname,lastname)
            {
               
                this.Middlename = middlename;
            }
        public string Lastname { get; set; }


        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string Fullname
        {
            get { return GetFullName(); }
        }
        public string Reversename
        {
            get { return GetReverseName(); }
        }

        private string GetFullName()
        {
            return Firstname + " " + Middlename + " " + Lastname;
        }
        private string GetReverseName()
        {
               if (GetFullName() == null) return null;
               char[] array = GetFullName().ToCharArray();
               Array.Reverse(array);
               return new String(array);

           
        }

    }
}
