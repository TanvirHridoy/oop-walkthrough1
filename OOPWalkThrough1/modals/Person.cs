using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.modals
{
    class Person
    {
        public Person(string firstname, string middlename, string lastname)
        {

            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
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

        private String GetFullName()
        {
            return Firstname + " " + Middlename + " " + Lastname;
        }
        private String GetReverseName()
        {
               if (GetFullName() == null) return null;
               char[] array = GetFullName().ToCharArray();
               Array.Reverse(array);
               return new String(array);

           
        }

    }
}
