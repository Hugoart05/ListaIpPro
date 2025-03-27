using DataBase.Config;
using DataBase.Repository.implementations;
using DataBase.Repository.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class ServiceColectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddDbContext<DbConfig>();
        }
    }
}
