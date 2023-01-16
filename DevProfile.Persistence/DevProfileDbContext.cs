using DevProfile.Application.Features.Experiences.Queries.GetExperiencesWithProjects;
using DevProfile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Persistence
{
    public class DevProfileDbContext : DbContext
    {
        public DevProfileDbContext(DbContextOptions<DevProfileDbContext> options)
            : base(options)
        {
        }

        public DbSet<Experience> Expereiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DevProfileDbContext).Assembly);

            //seed data
            var perotGuid = Guid.Parse("{773FD7D8-AB7F-47DF-8C10-2DB3FA11B384}");
            var sumeruGuid = Guid.Parse("{6253FB3C-568B-4D8C-B3DF-325A5F52051F}");

            modelBuilder.Entity<Experience>().HasData(new Experience
            {
                Company = "Perot Systems",
                Designation = "Associate",
                ExperienceId= perotGuid,
                StartDate = new DateTime(2005, 7, 18),
                EndDate = new DateTime(2007, 2, 19)
            });
            modelBuilder.Entity<Experience>().HasData(new Experience
            {
                Company = "Someru Software",
                Designation = "Solution Architect/ Tech Lead",
                ExperienceId = sumeruGuid,
                StartDate = new DateTime(2007, 2, 22),
                EndDate = new DateTime(2014, 10, 31)
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = perotGuid,
                Name = "Cartus",
                Order = 100,
                DetailedDescription = "This project has been developed in order to automate various services provided by Cartus. The Project is divided into modules." +
                "It takes care of all the policies defined on the basis of mutual agreement between Cartus and its clients.",
                MaxTeamSize = 8,
                CreatedBy = "Code",
                CreatedDate = DateTime.Today.Date,
                ShortDescription = "This project has been developed in order to automate various services provided by Cartus.",
                ExperienceId = perotGuid,
                LastModifiedBy = String.Empty,
                Responsibilites = new List<string>
                {
                    "Fixing defects as a part of production-support team",
                    "Coding for different enhancements for the application"
                },
                Role = "Associate",
                TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server"
            });
        }
    }
}
