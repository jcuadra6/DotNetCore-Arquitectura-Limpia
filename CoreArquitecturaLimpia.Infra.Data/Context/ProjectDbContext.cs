using CoreArquitecturaLimpia.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreArquitecturaLimpia.Infra.Data.Context
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}