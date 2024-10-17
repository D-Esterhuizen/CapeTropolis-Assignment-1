using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class ProductViewModel
    {
        public int SelectedHotelId {  get; set; }
        
        public int SelecteedMealId { get; set; }
        public List<Meal> Meals { get; set; }

        public List<Room> Rooms { get; set;}

        public int SelectedRoomId { get; set; }
        //not working
       /* public List<MealType> MealTypes { get; set; }*/ 

    }
}