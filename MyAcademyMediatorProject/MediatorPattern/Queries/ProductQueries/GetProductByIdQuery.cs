using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

namespace MyAcademyMediatorProject.MediatorPattern.Queries.ProductQueries;

public record GetProductByIdQuery(Guid Id) : IRequest<GetProductByIdQueryResult>;
