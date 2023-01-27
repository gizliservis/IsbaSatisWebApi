using IsbaSatisWeb.Application.Repositories;
using IsbaSatisWeb.Infrastructure.Persistence;
using IsbaSatisWeb.Infrastructure.Persistence.Contexts;
using IsbaSatisWeb.Persistence.Repositories;
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
            services.AddScoped<ITanimRepository, TanimRepository>();
            services.AddScoped<IStokHareketRepository, StokHareketRepository>();
            services.AddScoped<IStokRepository, StokRepository>();
            services.AddScoped<ISirketBilgiRepository, SirketBilgiRepository>();
            services.AddScoped<IPersonelHareketRepository, PersonelHareketRepository>();
            services.AddScoped<IPersonelRepository, PersonelRepository>();
            services.AddScoped<IOdemeTuruRepository, OdemeTuruRepository>();
            services.AddScoped<IKodRepository, KodRepository>();
            services.AddScoped<IKasaHareketRepository, KasaHareketRepository>();
            services.AddScoped<IKasaRepository, KasaRepository>();
            services.AddScoped<IIndirimRepository, IndirimRepository>();
            services.AddScoped<IHizliSatisGrupRepository, HizliSatisGrupRepository>();
            services.AddScoped<IHizliSatisRepository, HizliSatisRepository>();
            services.AddScoped<IFisRepository, FisRepository>();
            services.AddScoped<IDepoRepository, DepoRepository>();
            services.AddScoped<ICariRepository, CariRepository>();
            services.AddScoped<IBankaHareketRepository, BankaHareketRepository>();
            services.AddScoped<IBankaRepository, BankaRepository>();
        }
    }
}
