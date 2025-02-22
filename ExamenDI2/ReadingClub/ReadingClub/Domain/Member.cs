using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ReadingClub.Domain
{
    class Member
    {
        public String Name { get; set; }

        public String DateBirth {  get; set; }

        public String Email {  get; set; }

        public String Phone { get; set; }

        public Member(String name, String dateBirth, String email, String phone)
        {
            Name = name;
            DateBirth = dateBirth;
            Email = email;
            Phone = phone;
        }
    }
}
