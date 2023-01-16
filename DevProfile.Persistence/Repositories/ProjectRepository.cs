using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Persistence.Repositories
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(DevProfileDbContext context) : base(context)
        {
        }
        public Task<bool> IsProjectNameUnique(string name)
        {
            var match = _context.Projects.Any(e => e.Name.Equals(name));
            return Task.FromResult(match);
        }
    }
}
