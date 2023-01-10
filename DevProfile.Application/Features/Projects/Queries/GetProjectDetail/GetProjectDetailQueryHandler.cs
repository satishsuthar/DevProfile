using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Queries.GetProjectDetail
{
    public class GetProjectDetailQueryHandler : IRequestHandler<GetProjectDetailQuery, ProjectDetailVM>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Project> _projectRepository;
        private readonly IAsyncRepository<Experience> _experienceRepository;

        public GetProjectDetailQueryHandler(IMapper mapper, IAsyncRepository<Project> projectRepository, IAsyncRepository<Experience> experienceRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
            _experienceRepository = experienceRepository;
        }

        public async Task<ProjectDetailVM> Handle(GetProjectDetailQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);
            var projectDetail = _mapper.Map<ProjectDetailVM>(project);
            var experience = await _experienceRepository.GetByIdAsync(project.ExperienceId);
            projectDetail.Experience = _mapper.Map<ExperienceDto>(experience);
            return projectDetail;
        }
    }
}
