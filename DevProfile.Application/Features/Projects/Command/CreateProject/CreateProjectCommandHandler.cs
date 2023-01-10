using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, CreateProjectCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public CreateProjectCommandHandler(IMapper mapper, IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<CreateProjectCommandResponse> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var createProjectCommandResponse = new CreateProjectCommandResponse();

            var projects = _mapper.Map<Project>(request);

            var validator = new CreateProjectCommandValidator(_projectRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                createProjectCommandResponse.Success = false;
                createProjectCommandResponse.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    createProjectCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (createProjectCommandResponse.Success)
            {
                var project = _mapper.Map<Project>(request);
                project = await _projectRepository.AddAsync(project);
                createProjectCommandResponse.Project = _mapper.Map<CreateProjectDto >(project); 
            }
            return createProjectCommandResponse;
        }
    }
}
