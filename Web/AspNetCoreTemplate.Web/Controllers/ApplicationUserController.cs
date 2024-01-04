//using Blog.Infrastructure.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
//using Blog.Core.Models.User;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    [Authorize]
    public class ApplicationUserController : Controller
    {
        //private readonly UserManager<ApplicationUser> userManager;

        //private readonly SignInManager<ApplicationUser> signInManager;

        public ApplicationUserController()
        {
            //userManager = _userManager;
            //signInManager = _signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return this.View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = new ApplicationUser()
        //    {
        //        Email = model.Email,
        //        UserName = model.UserName
        //    };

        //    var result = await userManager.CreateAsync(user, model.Password);

        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Login", "ApplicationUser");
        //    }

        //    foreach (var item in result.Errors)
        //    {
        //        ModelState.AddModelError("", item.Description);
        //    }

        //    return View(model);
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await userManager.FindByNameAsync(model.UserName);

        //    if (user != null)
        //    {
        //        var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("All", "Article");
        //        }
        //    }

        //    ModelState.AddModelError("", "Invalid login");

        //    return View(model);
        //}

        public async Task<IActionResult> Logout()
        {
            //await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
