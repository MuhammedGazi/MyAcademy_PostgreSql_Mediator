using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;

namespace MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

public record GetProductsQueryResult(Guid Id,
                                     string Name,
                                     decimal Price,
                                     int Stock,
                                     GetCategoriesQueryResult Category);
