using Mapster;
using MediatR;
using MyAcademyMediatorProject.Entities;
using MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;
using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;
using MyAcademyMediatorProject.Repositories;

namespace MyAcademyMediatorProject.MediatorPattern.Handlers.CategoryHandlers
{
    public class GetCategoriesQueryHandler(IRepository<Category> _repository) : IRequestHandler<GetCategoriesQuery, List<GetCategoriesQueryResult>>
    {
        public async Task<List<GetCategoriesQueryResult>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();
            return categories.Adapt<List<GetCategoriesQueryResult>>();
        }
    }
}
