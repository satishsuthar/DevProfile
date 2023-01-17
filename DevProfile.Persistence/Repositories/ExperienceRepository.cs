using DevProfile.Application.Contracts.Persistence;
using DevProfile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Persistence.Repositories
{
    public class ExperienceRepository : BaseRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(DevProfileDbContext context) : base(context)
        {
        }

        public async Task<List<Experience>> GetExpereiencesWithProjects()
        {
            return await _context.Experiences.Include(x=>x.Projects).ToListAsync();
        }
    }
}
