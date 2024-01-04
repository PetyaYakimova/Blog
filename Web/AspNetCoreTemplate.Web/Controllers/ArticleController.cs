namespace Blog.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ArticleController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
