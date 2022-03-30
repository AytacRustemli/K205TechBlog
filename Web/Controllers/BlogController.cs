using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogManager _blogManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BlogController(IBlogManager blogManager, IHttpContextAccessor httpContextAccessor)
        {
            _blogManager = blogManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Detail(int? id)
        {
            //var blog = _blogManager.GetById(id);
            BlogSingleVM vm = new()
            {
                BlogSingle = _blogManager.GetById(id),

            };
            return View(vm);
        }
    }
}
