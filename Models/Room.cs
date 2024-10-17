using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23668475_HW01.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public int PricPN { get; set; }
        public string Features { get; set; }
        public int HotelId { get; set; }
    }
}