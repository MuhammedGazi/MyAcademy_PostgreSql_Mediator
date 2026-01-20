using MediatR;
using MyAcademyMediatorProject.Entities;
using MyAcademyMediatorProject.MediatorPattern.Commands.CategoryCommands;
using MyAcademyMediatorProject.Repositories;

namespace MyAcademyMediatorProject.MediatorPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler(IRepository<Category> repository) : IRequestHandler<RemoveCategoryCommand>
    {
        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(request.Id);
        }
    }
}
