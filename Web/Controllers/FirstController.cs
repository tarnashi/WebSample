using System.Web.Mvc;
using Web.Attributes;

namespace Web.Controllers
{
    [Authorize]
    [CustomAuthorize("admin", "user")]
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
    }
}