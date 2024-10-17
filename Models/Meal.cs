using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealType { get; set; }    
        public int HotelId { get; set; }

    }

    //not working
    public class MealType
    {
        public string OMealtype { get; set; }
    }
}