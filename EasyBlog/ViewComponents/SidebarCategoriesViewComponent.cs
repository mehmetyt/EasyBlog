using EasyBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlog.ViewComponents
{
    public class SidebarCategoriesViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public SidebarCategoriesViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            return View(_db.Categories.ToList());
        }
    }
}
