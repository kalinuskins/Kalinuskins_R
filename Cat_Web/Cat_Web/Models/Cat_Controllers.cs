using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cat_Web.Models
{
    public class Cat_Controllers : Controller
    {
        // GET: Cat_Controllers
        public ActionResult Index()
        {
            using (var catDb = new catDb())

                return View();

        }
    }
}