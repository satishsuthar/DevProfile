using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Projects.Queries.GetProjectDetail
{
    public class ProjectDetailVM
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string TechnologyStack { get; set; }
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public int MaxTeamSize { get; set; }
        public int Order { get; set; }
        public string Role { get; set; }
        public List<string> Responsibilites { get; set; } = new List<string>();
        public ExperienceDto Experience { get; set; }


    }
}
