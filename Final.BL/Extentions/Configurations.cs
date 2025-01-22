using Final.BL.Profiles;
using Final.BL.Services.Abstracts;
using Final.BL.Services.Concrets;
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

namespace Final.BL.Extentions
{
    public static class Configurations
    {
        public static void AddBlServices(this IServiceCollection services)
        {
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<ITreatmentService, TreatmentService>();
            services.AddAutoMapper(typeof(TreatmentProfile));
            services.AddAutoMapper(typeof(DoctorProfile));
            services.AddAutoMapper(typeof(IdentityUserProfile));
        }
    }
}
