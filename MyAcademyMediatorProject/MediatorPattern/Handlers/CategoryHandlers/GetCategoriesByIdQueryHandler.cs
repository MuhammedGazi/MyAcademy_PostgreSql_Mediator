using Mapster;
using MediatR;
using MyAcademyMediatorProject.Entities;
using MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;
using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;
using MyAcademyMediatorProject.Repositories;

namespace MyAcademyMediatorProject.MediatorPattern.Handlers.CategoryHandlers
{
    public class GetCategoriesByIdQueryHandler(IRepository<Category> _repository) : IRequestHandler<GetCategoriesByIdQuery, GetCategoriesByIdQueryResult>
    {
        public async Task<GetCategoriesByIdQueryResult> Handle(GetCategoriesByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.id);
            return category.Adapt<GetCategoriesByIdQueryResult>();
        }
    }
}
