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
    public class KeyLessEntityConfig : IEntityTypeConfiguration<KeyLessEntity>
    {
        public void Configure(EntityTypeBuilder<KeyLessEntity> builder)
        {
            builder.HasNoKey();
        }
    }
}
