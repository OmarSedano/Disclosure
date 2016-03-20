using System.Web.Mvc;

namespace Disclosure.Controllers
{
    public class DisclosureController: Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View("~/Views/Disclosure/Templates/_home.cshtml");
        }
    }
}