using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Commands.ProductCommands;

public record DeleteProductCommand(Guid Id) : IRequest;
