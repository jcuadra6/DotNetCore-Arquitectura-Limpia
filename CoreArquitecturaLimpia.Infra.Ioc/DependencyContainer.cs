using CoreArquitecturaLimpia.Application.Interfaces;
using CoreArquitecturaLimpia.Application.Services;
using CoreArquitecturaLimpia.Domain.Interfaces;
using CoreArquitecturaLimpia.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoreArquitecturaLimpia.Infra.Ioc
{
    public class DependencyContainer
    
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            /*
            services.AddTransient<IEmailSender, EmailSender>();
        */
        }
    }
}