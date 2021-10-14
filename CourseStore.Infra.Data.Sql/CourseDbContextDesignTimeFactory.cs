using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    class CourseDbContextDesignTimeFactory : IDesignTimeDbContextFactory<CourseDbContext>
    {
        public CourseDbContext CreateDbContext(string[] args) =>
            ContextFactory.GetSqlDbContext();
    }
}
