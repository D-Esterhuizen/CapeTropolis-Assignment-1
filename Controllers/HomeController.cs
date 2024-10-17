using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23668475_HW01.Models;

namespace u23668475_HW01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewOrder()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Meals()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            /*string Hotels = GetRoomsByHotel(1);*/
                

            return View(/*Hotels*/);
        }
        public ActionResult CapeHoneyBooking()
        {

            List<Room> rooms = GetRoomsByHotel(1);

            return View(rooms);
        }
        public ActionResult CapeIvoryBooking()
        {
            List<Room> rooms = GetRoomsByHotel(2);

            return View(rooms);
        }
        public ActionResult CapeSweetBooking()
        {
            List<Room> rooms = GetRoomsByHotel(3);

            return View(rooms);

        }

        public ActionResult CapeHiveBooking()
        {

            List<Room> rooms = GetRoomsByHotel(4);

            return View(rooms);
        }

        public ActionResult CapeCowBooking()
        {
            List<Room> rooms = GetRoomsByHotel(5);

            return View(rooms);
        }

        public List<Room> GetRoomsByHotel(int HotelID)
        {
            var Rooms = Repository.GetRooms()
                .Where(r => r.HotelId == HotelID)
                .ToList();

            return Rooms;
        }

        public ActionResult MealProviderPage()
        {
            return View();
        }
        public ActionResult BookingConfirmation()
        {
            return View();
        }
        public ActionResult OrderMealPage()
        {
            return View();
        }




        public ActionResult AddProduct(string FirstName, string Surname, string Email, string PhoneNumber)
        {
            return Content("OK", "text/plain");
        }



    }
}



