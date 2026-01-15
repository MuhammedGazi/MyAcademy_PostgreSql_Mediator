using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;
using System.Threading.Tasks;

namespace MyAcademyMediatorProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _mediator.Send(new GetCategoriesQuery());
            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(Guid id)
        {
            var category=await _mediator.Send(new GetCategoriesByIdQuery(id));
            return View(category);
        }
    }
}
