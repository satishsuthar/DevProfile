using DevProfile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Features.Experiences.Queries.GetExperiences
{
    public class ExperienceVM
    {
        public Guid ExperienceId { get; set; }
        public string Company { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; } = string.Empty;
        public ICollection<Project> Projects { get; set; }
    }
}
