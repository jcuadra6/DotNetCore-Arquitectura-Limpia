using System.Collections.Generic;
using CoreArquitecturaLimpia.Domain.Models;

namespace CoreArquitecturaLimpia.Application.ViewModels
{
    public class ProjectViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}