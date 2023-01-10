using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Experiences.Queries.GetExperiencesWithProjects
{
    public class GetExperiencesWithProjectsQueryHandler : IRequestHandler<GetExperiencesWithProjectsQuery, List<ExperienceWithProjectsVM>>
    {
        private readonly IMapper _mapper;
        private readonly IExperienceRepository _experienceRepository;

        public GetExperiencesWithProjectsQueryHandler(IMapper mapper, IExperienceRepository experienceRepository)
        {
            _mapper = mapper;
            _experienceRepository = experienceRepository;
        }

        public async Task<List<ExperienceWithProjectsVM>> Handle(GetExperiencesWithProjectsQuery request, CancellationToken cancellationToken)
        {
            var expereiencesWithProjects = await _experienceRepository.GetExpereiencesWithProjects();
            return _mapper.Map<List<ExperienceWithProjectsVM>>(expereiencesWithProjects);
        }
    }
}
