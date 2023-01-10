using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Queries.GetProjectDetail
{
    public class GetProjectDetailQuery : IRequest<ProjectDetailVM>
    {
        public Guid Id { get; set; }
    }
}
