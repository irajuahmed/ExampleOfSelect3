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
            var setDataList = new List<DropdownList>
            {
                new DropdownList{id=1,text="Test Data-1"},
                new DropdownList{id=2,text="Test Data-2"}
            };

            for (int i = 0; i < 50000; i++)
            {
                list.Add(new DropdownList() { id = i, text = "Test Data-" + i });
            }

            ViewBag.DataToSet = JsonConvert.SerializeObject(setDataList);
            ViewBag.DataAsList = JsonConvert.SerializeObject(list);

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