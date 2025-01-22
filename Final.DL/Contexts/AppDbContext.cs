using Final.CL.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Final.DL.Contexts
{
    public class AppDbContext:IdentityDbContext<IdentityUser, IdentityRole,string>
    {

        public AppDbContext(DbContextOptions opt):base(opt)
        {
                
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityRole>().HasData(new IdentityRole {Id="rwgewgainsoi",Name="Admin",NormalizedName="ADMIN" }, new IdentityRole { Id = "asfasff", Name = "User", NormalizedName = "USER" });
            IdentityUser admin = new()
            {
                Id = "qawfsfqw3f",
                UserName = "amdin",
                NormalizedUserName = "AMDIN"
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            passwordHasher.HashPassword(admin, "amdin123");
            builder.Entity<IdentityUser>().HasData(admin);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "qawfsfqw3f", RoleId = "rwgewgainsoi"
            } );
            builder.Entity<Doctor>().HasData(new Doctor
            {
                Id = 1,
                ImageURL= "images/team1.jpg",
                Name = "Mesum",
                TreatmentId =1,
                CreatedAt = DateTime.Now,

            });
            builder.Entity<Treatment>().HasData(new Treatment
            {
                Id = 1,
                Title="Dis hekimi",
                Description="Gelin disinizi alin,razi qalin",
                ImageURL= "images/t1.png",

            });

            base.OnModelCreating( builder );
        }
    }
}
