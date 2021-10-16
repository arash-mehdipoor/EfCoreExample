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
        public DbSet<KeyLessEntity> keyLessEntities { get; set; }
        public DbSet<Student> Students { get; set; }
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
            

            // Set Index For Feild
            //modelBuilder.Entity<Course>().HasIndex(c => c.Title);
            //modelBuilder.Entity<Person>().HasIndex(c => new { c.FullName, c.Id });

            //Set Name For Debug
            //modelBuilder.Entity<Person>().HasIndex(c => new { c.FullName, c.Id }).HasName("name");

            //Set View
            //modelBuilder.Entity<KeyLessEntity>().ToView("vm_viewName");

            // Sql Query For HasIndex
            //modelBuilder.Entity<Person>().HasIndex(c => new { c.FullName, c.Id }).HasFilter("sql query");

            // set Schema
            //modelBuilder.HasDefaultSchema("con");

            // Ignore Tag
            //modelBuilder.Ignore<Tag>();

            // suft Deleted
            //modelBuilder.Entity<Course>().HasQueryFilter(x => x.IsDeleted == false);

            // Exclude Entity From Migrations
            //modelBuilder.Entity<Tag>().ToTable("Tags",t => t.ExcludeFromMigrations());


            if (Database.IsSqlServer())
            {
                // Another Code
            }
            else
            {

            }
            if (Database.IsRelational())
            {

            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
