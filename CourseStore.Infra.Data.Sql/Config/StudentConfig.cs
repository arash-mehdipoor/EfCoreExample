using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property<int>("InsertBy");
            builder.Property<DateTime>("InsertDate");
            builder.Property<int>("UpdateBy");
            builder.Property<DateTime>("UpdateDate");
        }
    }
}
