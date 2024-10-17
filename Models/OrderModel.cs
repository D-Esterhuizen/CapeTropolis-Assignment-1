using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class OrderModel
    {
        
        public int OrderID { get; set; }
        [Display(Name = "First Name")]
        public string OFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string OLastName { get; set; }
        [Display(Name = " Meal Type")]
        public string MealType { get; set; }
        [Display(Name = "Meal Agent")]
        public string MealAgent { get; set; }
        [Display(Name = " Meal Description")]
        public string MealDesc { get; set; }

        [Display(Name = "Hotel Residence")]

        [Required(ErrorMessage = "Hotel Residence is required")]
        public string HotelResidence { get; set; }

    }
}