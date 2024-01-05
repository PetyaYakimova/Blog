namespace Blog.Controllers
{
    using System.Threading.Tasks;
    using Blog.Services.Data;

    //using Blog.Infrastructure.Models;
    using Blog.Web.ViewModels.ApplicationUser;
    //using Blog.Core.Models.User;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Migrations.Internal;

    //[Authorize]
    public class ApplicationUserController : Controller
    {
        private readonly IApplicationUserService userService;

        public ApplicationUserController(IApplicationUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        //[AllowAnonymous]
        public IActionResult Register()
        {
            return this.View(new RegisterUserInputModel());
        }

        [HttpPost]
        //[AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUserInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool usernameOrEmailTaken = await this.userService.UsernameExistsAsync(model.Username) ||
                                        await this.userService.EmailExistsAsync(model.Email);

            if (usernameOrEmailTaken)
            {
                return this.RedirectToAction("Login");
            }

            if (model.Password != model.PasswordConfirmation)
            {
                return this.View(model);
            }

            await this.userService.CreateUserAsync(model);

            return this.RedirectToAction("Login");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginInputModel());
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
