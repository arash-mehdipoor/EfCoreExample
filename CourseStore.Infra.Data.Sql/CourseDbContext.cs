using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{

    public class CourseDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Discount> DisCounts { get; set; }
        public DbSet<CourseTeacher> courseTeachers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonValueConvesion> PersonValueConvesions { get; set; }
        
        public CourseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Ignore Tag
            //modelBuilder.Ignore<Tag>();

            // suft Deleted
            //modelBuilder.Entity<Course>().HasQueryFilter(x => x.IsDeleted == false);

            // Exclude Entity From Migrations
            //modelBuilder.Entity<Tag>().ToTable("Tags",t => t.ExcludeFromMigrations());
            base.OnModelCreating(modelBuilder);
        }
    }
}
