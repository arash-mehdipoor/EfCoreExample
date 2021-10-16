using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql.Config
{



    class EncryptedConverter : ValueConverter<string, string>
    {
        public EncryptedConverter(ConverterMappingHints mappingHints = default)
            : base(EncryptExpr, DecryptExpr, mappingHints)
        { }

        static Expression<Func<string, string>> DecryptExpr = x => new string(x.Reverse().ToArray());
        static Expression<Func<string, string>> EncryptExpr = x => new string(x.Reverse().ToArray());
    }

    public class PersonValueConvesionConfig : IEntityTypeConfiguration<PersonValueConvesion>
    {
        public void Configure(EntityTypeBuilder<PersonValueConvesion> builder)
        {
            builder.Property(p => p.PersonType).HasConversion<string>();

            // Create Value Converter For NationalCode
           // var valueConverter = new ValueConverter<NationalCode, string>
             //   (c => c.Value, s => new NationalCode(s));
           // builder.Property(n => n.NationalCode).HasConversion(valueConverter);

            // SerializeObject DeserializeObject by HasConversion 
           // builder.Property(c => c.Name).HasConversion(c => JsonConvert.SerializeObject(c),
            //    s => JsonConvert.DeserializeObject<PersonName>(s));


           // builder.Property(c => c.Name).HasConversion(new EncryptedConverter());
            
        }
    }
}
