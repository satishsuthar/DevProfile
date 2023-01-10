using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Project> _projectRepository;

        public UpdateProjectCommandHandler(IMapper mapper, IAsyncRepository<Project> projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var projectToUpdate = await _projectRepository.GetByIdAsync(request.ProjectId);
            _mapper.Map(request, projectToUpdate, typeof(UpdateProjectCommand), typeof(Project));
            await _projectRepository.UpdateAsync(projectToUpdate);
            return Unit.Value;
        }
    }
}
