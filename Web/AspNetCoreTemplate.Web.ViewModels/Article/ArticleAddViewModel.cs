namespace Blog.Web.ViewModels.Article
{
    using System.Collections.Generic;

    using Blog.Data.Models;
    using Blog.Web.ViewModels.Genres;

    public class ArticleAddViewModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int GenreId { get; set; } //Selected genre

        public ICollection<ListGenreArticleAddViewModel> Genres { get; set; }
    }
}
