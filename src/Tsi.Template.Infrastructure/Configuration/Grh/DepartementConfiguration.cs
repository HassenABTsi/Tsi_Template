using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Domain.Grh;
using Tsi.Template.Infrastructure.Abstraction;

namespace Tsi.Template.Infrastructure.Configuration.Grh
{
    class DepartementConfiguration : EntityConfiguration<Departement>
    {
        public override void Configure(EntityTypeBuilder<Departement> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.code)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasIndex(e => e.code)
                .IsUnique();

            builder.Property(e => e.Libelle)
                .IsRequired();
        }
    }
}
