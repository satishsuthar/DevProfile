using AutoMapper;
using DevProfile.Application.Features.Experiences.Queries.GetExperiences;
using DevProfile.Application.Features.Experiences.Queries.GetExperiencesWithProjects;
using DevProfile.Application.Features.Projects.Command.CreateProject;
using DevProfile.Application.Features.Projects.Command.DeleteProject;
using DevProfile.Application.Features.Projects.Command.UpdateProject;
using DevProfile.Application.Features.Projects.Queries.GetProjectDetail;
using DevProfile.Application.Features.Projects.Queries.GetProjects;
using DevProfile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProfile.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Experience, ExperienceVM>().ReverseMap();
            CreateMap<Project, ProjectVM>().ReverseMap();
            CreateMap<Experience, ExperienceDto>();
            CreateMap<Project, ProjectDetailVM>().ReverseMap();
            CreateMap<Experience, ExperienceWithProjectsVM>();
            CreateMap<Project, ExperienceProjectDto>();
            CreateMap<Project, CreateProjectCommand>().ReverseMap();
            CreateMap<Project, UpdateProjectCommand>().ReverseMap();
            CreateMap<Project, DeleteProjectCommand>().ReverseMap();
            CreateMap<Project, CreateProjectDto>().ReverseMap();
        }
    }
}
