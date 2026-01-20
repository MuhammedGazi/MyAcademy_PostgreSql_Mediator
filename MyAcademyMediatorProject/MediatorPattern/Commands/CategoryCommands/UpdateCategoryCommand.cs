using MediatR;

namespace MyAcademyMediatorProject.MediatorPattern.Commands.CategoryCommands;

public record UpdateCategoryCommand(Guid Id, string Name) : IRequest;
