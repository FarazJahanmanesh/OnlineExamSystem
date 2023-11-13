using Application.Services;
using Database.Repository.User;
using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Dependencies
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region add Dependencies
            services.AddScoped< IUserServices , UserServices > ();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAcademyRepository, AcademyRepository>();
            services.AddScoped<IAcademyServices, AcademyServices>();
            #endregion
        }
    }
}
