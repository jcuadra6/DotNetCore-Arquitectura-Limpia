using CoreArquitecturaLimpia.Application.Interfaces;
using CoreArquitecturaLimpia.Application.ViewModels;
using CoreArquitecturaLimpia.Domain.Interfaces;

namespace CoreArquitecturaLimpia.Application.Services
{
    public class ProjectService : IProjectService
    {
        public IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ProjectViewModel GetProjects()
        {
            return new ProjectViewModel()
            {
                Projects = _projectRepository.GetProjects()
            };
        }
    }
}