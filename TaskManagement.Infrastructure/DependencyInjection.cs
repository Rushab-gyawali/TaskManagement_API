using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ImplementPersistence(this
            IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<TaskManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(TaskManagementDbContext).Assembly.FullName)), ServiceLifetime.Scoped);



            services.AddScoped<ITaskManagementDbContext>(provider => 
            provider.GetService<TaskManagementDbContext>());

            return services;
        }
    }
}
