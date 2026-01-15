using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;

namespace MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;

public record GetCategoriesByIdQuery(Guid id) : IRequest<GetCategoriesByIdQueryResult>;
