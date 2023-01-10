using DevProfile.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Domain.Entities
{
    public class Experience : AuditableEntities
    {
        public Guid ExperienceId { get; set; }
        public string Company { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; } = string.Empty;
        public ICollection<Project> Projects { get; set; }
    }
}
