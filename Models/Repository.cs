using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class Repository
    {
        public static List<Hotel> GetHotels()
        {
            return new List<Hotel>
    {
            new Hotel {HotelId= 1, HotelName= "CapeHoney"},
            new Hotel {HotelId= 2, HotelName= "CapeIvory"},
            new Hotel {HotelId= 3, HotelName= "CapeSweet"},
            new Hotel {HotelId= 4, HotelName= "CapeHive"},
            new Hotel {HotelId= 5, HotelName= "CapeCow"},


    };
                
                
                }
        public static List<Room> GetRooms()
        {
            return new List<Room>
    {//CapeHoney
        new Room {RoomID=1, RoomType="Standard", PricPN=3000, Features="Breakfast excluded, single bed, TV, internet", HotelId=1 },
        new Room {RoomID=2, RoomType="Deluxe", PricPN=5000, Features="Breakfast included, double (2) single beds, TV, internet", HotelId=1 },
        new Room {RoomID=3, RoomType="Exquisite", PricPN=7000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator", HotelId=1},
        new Room {RoomID=4, RoomType="Executive", PricPN=10000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis", HotelId=1 },
        // CapeIvory
        new Room {RoomID=5, RoomType="Single", PricPN=2500, Features="Breakfast excluded; single bed, TV, internet", HotelId=2 },
        new Room {RoomID=6, RoomType="Double", PricPN=5000, Features="Breakfast included, double (2) single beds, TV, internet", HotelId=2 },
        new Room {RoomID=7, RoomType="Executive", PricPN=8000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, buffet voucher", HotelId=2 },
        //CapeSweet
        new Room {RoomID=8, RoomType="Tasty", PricPN=3500, Features="Breakfast included; two single beds, TV, internet", HotelId=3 },
        new Room {RoomID=9, RoomType="Comfort", PricPN=5000, Features="Breakfast included, two single beds, TV, internet, laundry, free parking", HotelId=3 },
        new Room {RoomID=10, RoomType="Executive", PricPN=9000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed, separate dining area", HotelId=3 },
        new Room {RoomID=11, RoomType="Diamond", PricPN=12000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed, room service, separate dining area, buffet", HotelId=3 },
        //CapeHive
        new Room {RoomID=12, RoomType="Standard", PricPN=5000, Features="Breakfast included, single bed, TV, internet, laundry, free parking", HotelId=4 },
        new Room {RoomID=13, RoomType="Double", PricPN=7000, Features="Breakfast included, double (2) single beds, TV, internet", HotelId=4 },
        new Room {RoomID=14, RoomType="Executive", PricPN=10000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis", HotelId=4 },

        new Room {RoomID=15, RoomType="Budget", PricPN=2500, Features="Breakfast excluded; single bed, TV, internet", HotelId=5 },
        new Room {RoomID=16, RoomType="Spotlight", PricPN=4000, Features="Breakfast included; two single beds, TV, internet", HotelId=5 },
        new Room {RoomID=17, RoomType="Deluxe", PricPN=6000, Features="Breakfast included, single bed, TV, internet, laundry, free parking, tourism tour of Capetropolis", HotelId=5 },
        new Room {RoomID=18, RoomType="Gold", PricPN=8000, Features="Breakfast included, single bed, TV, internet, complimentary drinks in refrigerator, laundry, free parking, tourism tour of Capetropolis", HotelId=5 },
        new Room {RoomID=19, RoomType="Diamond", PricPN=12000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis", HotelId=5 },
        new Room {RoomID=20, RoomType="Platinum", PricPN=15000, Features="Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis", HotelId=5},
    };
        }
        public static List<Meal> GetMeals()
        {
            return new List<Meal>
            {
                new Meal {MealId= 1, MealType= "", HotelId=1 },
                new Meal { MealId= 2, MealType="", HotelId=1 },
                new Meal { MealId= 6, MealType="", HotelId=1 },

                new Meal { MealId= 1, MealType="", HotelId=2 },
                new Meal { MealId= 2, MealType="", HotelId=2 },
                new Meal { MealId= 3, MealType="", HotelId=2 },
                new Meal { MealId= 4, MealType="", HotelId=2 },
                new Meal { MealId= 6, MealType="", HotelId=2 },
                new Meal { MealId= 7, MealType="", HotelId=2 },

                new Meal { MealId= 1, MealType="", HotelId=3 },
                new Meal { MealId= 2, MealType="", HotelId=3 },
                new Meal { MealId= 3, MealType="", HotelId=3 },
                new Meal { MealId= 4, MealType="", HotelId=3 },

                new Meal { MealId= 1, MealType="", HotelId=4 },
                new Meal { MealId= 2, MealType="", HotelId=4 },
                new Meal { MealId= 6, MealType="", HotelId=4 },
                new Meal { MealId= 8, MealType="", HotelId=4 },

                new Meal { MealId= 1, MealType="", HotelId=5 },
                new Meal { MealId= 2, MealType="", HotelId=5 },
                new Meal { MealId= 3, MealType="", HotelId=5 },
                new Meal { MealId= 4, MealType="", HotelId=5 },
                new Meal { MealId= 5, MealType="", HotelId=5 },
            };
        }

        //not working
        ///*public static List<MealType> GetMealTypes()
        //{
        //    return new List<MealType>
        //    {
        //        new MealType {OMealtype = "Regular"},
        //        new MealType {OMealtype = "Vegan"},
        //        new MealType {OMealtype = "Halal"},
        //        new MealType {OMealtype = "Kosher"},
        //        new MealType {OMealtype = "Indian"},
        //        new MealType {OMealtype = "Gluten-Free"},
        //        new MealType {OMealtype = "Keto"},
        //        new MealType {OMealtype = "Paleo"}
        //    };
        //}*/

        
    



    }
}