using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Queries.GetProjects
{
    public class ProjectVM
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string TechnologyStack { get; set; }
        public string ShortDescription { get; set; } = string.Empty;
        public int MaxTeamSize { get; set; }
        public int Order { get; set; }
        public string Role { get; set; }
    }
}
