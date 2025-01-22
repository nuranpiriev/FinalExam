using Final.CL.Models.Entities;
using Final.DL.Repositories.Abstracts;
using Final.DL.Repositories.Concrets;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final.DL.Extentions
{
    public static class Configurations
    {
        public static void AddDlServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Doctor>,Repository<Doctor>>();
            services.AddScoped<IRepository<Treatment>,Repository<Treatment>>();
        }
    }
}
