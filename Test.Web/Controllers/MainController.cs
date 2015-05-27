using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Web.Infrastructure;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var context = new DatatechContext();
            return Json(context.AddressBook.OrderBy(ab => ab.Unit), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Abinfo(int abid)
        {
            var context = new DatatechContext();

            try
            {
                var addressBook = context.AddressBook.Find(abid);
                if (addressBook == null)
                    throw new IndexOutOfRangeException("По данному идентификатору данные отсутствуют");

                return new XmlResult<AddressBook>(addressBook);
            }
            catch (Exception exc)
            {
                return new XmlResult<ErrorInfo>(new ErrorInfo{Type = exc.GetType().Name, Message = exc.Message, Stack = exc.StackTrace});
            }
        }
    }
}