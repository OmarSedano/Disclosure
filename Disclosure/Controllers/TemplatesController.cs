using System.Web.Mvc;

namespace Disclosure.Controllers
{
    public class TemplatesController: Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}