using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleOfSelect3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<DropdownList>();

            for (int i = 0; i < 500000; i++)
            {
                list.Add(new DropdownList() { id = i, text = "Test Data-" + i });
            }
            ViewBag.Data = JsonConvert.SerializeObject(list);
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
    }
}