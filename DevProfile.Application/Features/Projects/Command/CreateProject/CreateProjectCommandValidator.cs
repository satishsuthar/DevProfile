using DevProfile.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectCommandValidator :AbstractValidator<CreateProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectCommandValidator(IProjectRepository projectRepository) 
        {
            _projectRepository = projectRepository;

            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 50 characters");

            RuleFor(p => p.ShortDescription)
                .NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(p => p)
                .MustAsync(ProjectNameUnique)

        }

        private async Task<bool> ProjectNameUnique(CreateProjectCommand e, CancellationToken token)
        {
            return !(await _projectRepository.IsProjectNameUnique(e.Name));
        }
    }
}
