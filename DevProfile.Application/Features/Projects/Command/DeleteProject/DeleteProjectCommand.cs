using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.DeleteProject
{
    public class DeleteProjectCommand : IRequest
    {
        public Guid ProjectId { get; set; }
    }
}
