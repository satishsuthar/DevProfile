using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Queries.GetProjects
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, List<ProjectVM>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Project> _projectRepository;

        public GetProjectsQueryHandler(IMapper mapper, IAsyncRepository<Project> projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<List<ProjectVM>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var allProjects = (await _projectRepository.ListAllAsync()).OrderBy(x => x.Order).ToList();
            return _mapper.Map<List<ProjectVM>>(allProjects);
        }
    }
}
