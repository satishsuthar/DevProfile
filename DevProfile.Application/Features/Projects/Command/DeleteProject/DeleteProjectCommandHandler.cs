using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.DeleteProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Project> _projectRepository;

        public DeleteProjectCommandHandler(IMapper mapper, IAsyncRepository<Project> projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            await _projectRepository.DeleteAsync(request.ProjectId);
            return Unit.Value;
        }
    }
}
