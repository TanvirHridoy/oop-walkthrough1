using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.modals
{
    class Person
    {
        public string firstname;
        public string middlename;
        public string lastname;

        public String GetFullName()
        {
            return firstname + " " + middlename + " " + lastname;
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
