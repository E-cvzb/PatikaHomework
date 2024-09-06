using Microsoft.AspNetCore.Mvc;
using PatikaHomework.Models;

namespace PatikaHomework.Controllers
{
    public class CustomerOrderController : Controller
    {
        public IActionResult Index()
        {



            ViewBag.Id = 1;
           ViewBag.FirstName = "Mehmet";
            ViewBag.LastName = "Kuş";
            ViewBag.Email = "kuşmehmet@gmail.com";
            
         
            return View();


        }
        public IActionResult Index2()
        {



            ViewBag.Id = 2;
            ViewBag.FirstName = "Emrehan";
            ViewBag.LastName = "Çetin";
            ViewBag.Email = "çetin@gmail.com";
            

            return View();
        }
        public IActionResult Index3() 
        {



            ViewBag.OrderId = 1;
            ViewBag.ProductName = "Silgi";
            ViewBag.Price = 00001;
            ViewBag.Quantity = 15;
            
            return View();
        }

    }
}
