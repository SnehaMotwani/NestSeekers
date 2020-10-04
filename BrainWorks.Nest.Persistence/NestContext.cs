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
            modelBuilder.Entity<User>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.City).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Pin).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();

            modelBuilder.Entity<Role>().Property(b => b.Name).HasColumnType("varchar(200)").IsRequired();


            modelBuilder.Entity<UserRole>().HasOne(b => b.User).WithMany(b => b.UsersRoles).HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserRole>().HasOne(b => b.Role).WithMany(b => b.UserRoles).HasForeignKey(b => b.RoleId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
