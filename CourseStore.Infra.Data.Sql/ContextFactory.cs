using Microsoft.EntityFrameworkCore;

namespace CourseStore.Infra.Data.Sql
{
    public static class ContextFactory
    {
        public static CourseDbContext GetSqlDbContext()
        {
            var builder = new DbContextOptionsBuilder<CourseDbContext>();
            builder.UseSqlServer("Server=.;Initial Catalog=CoreExample;Integrated Security=True");
            return new CourseDbContext(builder.Options);
        }
    }
}
