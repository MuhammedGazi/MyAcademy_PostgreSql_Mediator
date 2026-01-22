namespace MyAcademyMediatorProject.MediatorPattern.Results.ProductResults;

public record GetProductByIdQueryResult(Guid Id,
                                        string Name,
                                        decimal Price,
                                        int Stock,
                                        Guid CategoryId);
