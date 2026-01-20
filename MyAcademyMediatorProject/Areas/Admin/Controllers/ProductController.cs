using Microsoft.AspNetCore.Mvc;

namespace MyAcademyMediatorProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
