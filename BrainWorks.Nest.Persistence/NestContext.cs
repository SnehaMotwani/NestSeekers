using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BrainWorks.Nest.Data.Model;

namespace BrainWorks.Nest.Persistence
{
    public class NestContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=RM-PC\\MYSQLSERVER;Initial Catalog=NestSeekerDatabase; Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();

        }
    }
}
