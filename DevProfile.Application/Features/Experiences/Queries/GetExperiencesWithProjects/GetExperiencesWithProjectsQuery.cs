using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Experiences.Queries.GetExperiencesWithProjects
{
    public class GetExperiencesWithProjectsQuery : IRequest<List<ExperienceWithProjectsVM>>
    {
    }
}
