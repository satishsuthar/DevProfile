using DevProfile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Contracts.Persistence
{
    public interface IExperienceRepository : IAsyncRepository<Experience>
    {
        Task<List<Experience>> GetExpereiencesWithProjects();
    }
}
