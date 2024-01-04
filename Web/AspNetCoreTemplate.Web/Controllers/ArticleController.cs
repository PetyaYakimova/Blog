namespace Blog.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Blog.Services.Data;
    using Blog.Web.ViewModels.Article;
    using Blog.Web.ViewModels.Genres;

    using Microsoft.AspNetCore.Mvc;

    public class ArticleController : Controller
    {
        private readonly IGenreService genreService;

        public ArticleController (IGenreService genreService)
        {
            this.genreService = genreService;
        }
        
        public async Task<IActionResult> Add()
        {
            ICollection<ListGenreArticleAddViewModel> genres = await this.genreService.GetAllAsync();

            ArticleAddViewModel vm = new ArticleAddViewModel()
            {
                Genres = genres,
            };

            return View(vm);
        }
    }
}
