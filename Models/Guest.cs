using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class Guest
    {
        public int GuestId { get; set; }
        public String Name { get; set; }    
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }

    }
}