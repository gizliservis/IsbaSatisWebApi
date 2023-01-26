using IsbaSatisWeb.Infrastructure.Persistence;
using IsbaSatisWeb.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<IsbaSatisWebDbContext>(options =>
                    options.UseSqlServer(Configuration.ConnectionString));
            //services.AddSingleton<IService,Service>();
        }
    }
}
