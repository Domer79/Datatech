using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            var context = new DatatechContext();

//            return View(context.AddressBook.OrderBy(ab => ab.Unit));
            return View(context.AddressBook);
        }
    }
}