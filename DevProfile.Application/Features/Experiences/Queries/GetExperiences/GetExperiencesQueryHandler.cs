using AutoMapper;
using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Experiences.Queries.GetExperiences
{
    public class GetExperiencesQueryHandler : IRequestHandler<GetExperiencesQuery, List<ExperienceVM>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Experience> _experienceRepository;

        public GetExperiencesQueryHandler(IMapper mapper, IAsyncRepository<Experience> experienceRepository)
        {
            _mapper = mapper;
            _experienceRepository = experienceRepository;
        }
        public async Task<List<ExperienceVM>> Handle(GetExperiencesQuery request, CancellationToken cancellationToken)
        {
            var allExperiences = (await _experienceRepository.ListAllAsync()).OrderBy(x => x.StartDate);
            return _mapper.Map<List<ExperienceVM>>(allExperiences);
        }
    }
}
