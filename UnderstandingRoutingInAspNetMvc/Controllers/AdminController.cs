using System.Web.Mvc;

namespace UnderstandingRoutingInAspNetMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/DeleteAll
        public ActionResult DeleteAll()
        {
            ViewBag.Message = "All accounts has been deleted.";
            return View();
        }
    }
}