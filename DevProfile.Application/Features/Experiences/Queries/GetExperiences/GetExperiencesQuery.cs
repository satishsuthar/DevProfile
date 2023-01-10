using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Experiences.Queries.GetExperiences
{
    public class GetExperiencesQuery : IRequest<List<ExperienceVM>>
    {
    }
}
