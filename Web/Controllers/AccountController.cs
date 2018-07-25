using System.Web.Mvc;
using System.Web.Security;
using Core.Abstract;
using Web.Models;

namespace Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IAuthService _auth;

        public AccountController(IAuthService authService)
        {
            _auth = authService;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (_auth.CheckLogin(loginViewModel.Login, loginViewModel.Password))
                {
                    FormsAuthentication.SetAuthCookie(loginViewModel.Login, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                }
                ModelState.AddModelError("", "Invalid authentication");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect(Url.Action("Login", "Account"));
        }
    }

}