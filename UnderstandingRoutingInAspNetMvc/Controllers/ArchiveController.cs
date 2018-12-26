using System;
using System.Web.Mvc;

namespace UnderstandingRoutingInAspNetMvc.Controllers
{
    public class ArchiveController : Controller
    {
        // GET: Archive/{entryDate}
        public ActionResult Entry(DateTime entryDate)
        {
            DateTime date = DateTime.Now;

            if (DateTime.TryParse(entryDate.ToString(), out date))
            {
                date = entryDate;
            }
            
            ViewBag.EntryDate = date < DateTime.Now.Date ? entryDate.ToString("MM/dd/yyyy") : DateTime.Now.ToString("MM/dd/yyyy") ;

            return View();
        }
    }
}