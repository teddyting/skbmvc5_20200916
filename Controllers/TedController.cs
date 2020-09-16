using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class TedController : Controller
    {

        static List<Client> list = new List<Client>()
        {
            new Client() { Id = 1, Name = "teddy", Phone = "111111111" },
            new Client() { Id = 2, Name = "tim", Phone = "11112222222" },
            new Client() { Id = 3, Name = "ok", Phone = "11113333333" }
        };



        public ActionResult Index(SearchClient keyword)
        {
            //List<Client> searchList = null;
            IEnumerable<Client> searchList = list;
            if ( keyword != null)
            {
                if (!string.IsNullOrEmpty(keyword.Name))
                {
                    searchList = list.Where(p => p.Name.Contains(keyword.Name));
                }
                if (!string.IsNullOrEmpty(keyword.Phone))
                {
                    searchList = searchList.Where(p => p.Phone.Contains(keyword.Phone));
                }

            }

            return View(searchList);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Client data)
        {
            if (ModelState.IsValid)
            {
                list.Add(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }


        public ActionResult Edit(int Id)
        {
            var item = list.FirstOrDefault(p=> p.Id == Id);

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            try
            {
                // TODO: Add update logic here
                var item = list.FirstOrDefault(p => p.Id == id);

                item.Name = client.Name;
                item.Phone = client.Phone;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        

    }
}