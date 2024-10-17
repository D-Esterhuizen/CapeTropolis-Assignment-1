using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace u23668475_HW01.Models
{
    public class CatererModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        
        public CatererModel()
        {
        
        }

    }
}