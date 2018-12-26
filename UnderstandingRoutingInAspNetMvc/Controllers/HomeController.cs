using System.Web.Mvc;

namespace UnderstandingRoutingInAspNetMvc.Controllers
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