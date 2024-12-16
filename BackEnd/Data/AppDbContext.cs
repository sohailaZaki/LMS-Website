﻿
using LMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<User> Users { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<AssessmentCriteria> AssessmentCriterias { get; set; }
        public  DbSet<Course> Courses { get; set; }
        public DbSet<AssignmentSubmissions> AssignmentSubmissions { get; set; }
        public DbSet<StudentProgresses> StudentProgresses { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
    new Role { Id = 1, Name = "Student" },
    new Role { Id = 2, Name = "Instructor" },
    new Role { Id = 3, Name = "Admin" }
);
            modelBuilder.Entity<User>().HasData(
   new User { Id = 1, FirstName ="Admin",LastName="1",Email="Admin@cis.asu.edu.eg", CreatedAt = new DateTime(2024, 12, 16), Password="admin1",RoleID=3,RoleName="Admin",Status="Active",UserName="Admin_1" },
   new User { Id = 2, FirstName = "Admin", LastName="2",Email="Admin@cis.asu.edu.eg", CreatedAt = new DateTime(2024, 12, 16), Password="admin2",RoleID=3, RoleName = "Admin",Status ="Active",UserName="Admin_2" }

);

        }
    }
}

