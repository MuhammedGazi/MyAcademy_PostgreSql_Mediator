using Mapster;
using MediatR;
using MyAcademyMediatorProject.Entities;
using MyAcademyMediatorProject.MediatorPattern.Queries.ProductQueries;
using MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;
using MyAcademyMediatorProject.Repositories;

namespace MyAcademyMediatorProject.MediatorPattern.Handlers.ProductHandlers
{
    public class GetProductsQueryHandler(IRepository<Product> _repository) : IRequestHandler<GetProductsQuery, List<GetProductsQueryResult>>
    {
        public async Task<List<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetAllAsync(x=>x.Category);
            return category.Adapt<List<GetProductsQueryResult>>();
        }
    }
}
