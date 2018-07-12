using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.modals
{
    class Person
    {
        public string Lastname { get; set; }


        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string Fullname
        {
            get { return GetFullName(); }
        }


        private String GetFullName()
        {
            return Firstname + " " + Middlename + " " + Lastname;
        }
        public String GetReverseName()
        {
               if (GetFullName() == null) return null;
               char[] array = GetFullName().ToCharArray();
               Array.Reverse(array);
               return new String(array);

           
        }

    }
}
