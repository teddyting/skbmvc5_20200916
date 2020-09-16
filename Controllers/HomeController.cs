using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        static List<Client> list = new List<Client>()
        {
            new Client() { Id = 1, Name = "teddy", Phone = "111111111" },
            new Client() { Id = 2, Name = "tim", Phone = "2222222" },
            new Client() { Id = 3, Name = "ok", Phone = "3333333" }
        };

        public HomeController()
        {
            
        }

        public ActionResult Index()
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


        public ActionResult Ted()
        {

            return View(list);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public ActionResult Details(int id)
        {
            var item = list.FirstOrDefault(p => p.Id == id);

            return View(item);
        }

        
    }
}