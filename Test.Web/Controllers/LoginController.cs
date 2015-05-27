using System.Net;
using System.Web.Mvc;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View((object) new LoginView());
        }

        [HttpPost]
        public ActionResult Index(LoginView loginView)
        {
            if (loginView.Login == "test1" && loginView.Password == "test2")
                return new HttpStatusCodeResult(HttpStatusCode.OK);

            return new HttpStatusCodeResult(401, "Не верный логин или пароль");
        }
    }
}