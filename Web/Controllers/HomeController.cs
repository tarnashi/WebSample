using Core;
using System.Web.Mvc;
using Core.Abstract;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _dataService;

        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(_dataService.GetWorkers());
        }

        public JsonResult ApiGetWorkers()
        {
            return Json(_dataService.GetWorkers(), JsonRequestBehavior.AllowGet);
        }
    }
}