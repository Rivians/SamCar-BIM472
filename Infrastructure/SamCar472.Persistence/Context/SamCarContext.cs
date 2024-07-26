using Microsoft.EntityFrameworkCore;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SamCar472.Persistence.Context
{
    public class SamCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OHHVBJO\\SQLEXPRESS; initial Catalog=SamCar; integrated Security=true; TrustServerCertificate=true");

            // OHHVBJO
            // J0UOEGM
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Blog>()
        //        .HasOne(b => b.AppUser)
        //        .WithMany(a => a.Blogs)
        //        .HasForeignKey(b => b.AppUserID);

        //    base.OnModelCreating(modelBuilder);
        //}


        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Author> Auhtors { get; set; }
        public DbSet<Blog> Blogs { get; set; }    
        public DbSet<Category> Categories { get; set; }    
        public DbSet<Comment> Comments { get; set; }    
        public DbSet<About> Abouts { get; set; }    
        public DbSet<Contact> Contacts { get; set; }    
    }
}
