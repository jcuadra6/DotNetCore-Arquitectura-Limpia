using System.Collections.Generic;
using CoreArquitecturaLimpia.Domain.Interfaces;
using CoreArquitecturaLimpia.Domain.Models;
using CoreArquitecturaLimpia.Infra.Data.Context;

namespace CoreArquitecturaLimpia.Infra.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public ProjectDbContext _context;
        public ProjectRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Project> GetProjects()
        {
            return _context.Projects;
        }
    }
}