using System.Web.Mvc;

namespace UnderstandingRoutingInAspNetMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Details(int productId)
        {
            ViewBag.ProductDetails = $"ProductId: {productId}";
            return View();
        }
    }
}