using firstMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace firstMVC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
