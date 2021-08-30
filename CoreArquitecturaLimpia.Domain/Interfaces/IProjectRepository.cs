using System.Collections.Generic;
using CoreArquitecturaLimpia.Domain.Models;

namespace CoreArquitecturaLimpia.Domain.Interfaces
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
    }
}