using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

namespace MyAcademyMediatorProject.MediatorPattern.Queries.ProductQueries;

public record GetProductsQuery : IRequest<List<GetProductsQueryResult>>;
