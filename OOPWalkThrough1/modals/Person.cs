using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.modals
{
    class Person
    {
        private string firstname;
        private string middlename;
        private string lastname;


        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public String GetFullName()
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
