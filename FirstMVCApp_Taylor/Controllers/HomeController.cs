using System.Web.Mvc;

namespace FirstMVCApp_Taylor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}