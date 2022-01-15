using FinMinister.Application.Contracts.Persistence;
using FinMinister.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinMinisterDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FinMinisterDbContextConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IExpenseRepository), typeof(ExpenseRepository));

            //services.AddScoped<IExpenseRepository, ExpenseRepository>();

            return services;
        }
    }
}
