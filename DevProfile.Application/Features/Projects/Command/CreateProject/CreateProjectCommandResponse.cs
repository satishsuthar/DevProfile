using DevProfile.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Command.CreateProject
{
    public class CreateProjectCommandResponse : BaseResponse
    {
        public CreateProjectCommandResponse() : base()
        {

        }

        public CreateProjectDto Project { get; set; } = default;
    }
}
