using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Infrastructure.Data.Mappings
{
    public class TB006_FrequenciaMap : IEntityTypeConfiguration<TB006_Frequencia>
    {
        public void Configure(EntityTypeBuilder<TB006_Frequencia> builder)
        {
            builder.ToTable("TB006_FREQUENCIA");
            builder.HasKey(x=>x.frequencia_Id);

            builder.Property(x => x.frequencia_Id)
               .HasColumnName("FREQUENCIA_ID")
               .IsRequired();

            builder.Property(x => x.frequencia_Nome)
                   .HasColumnName("FREQUENCIA_NOME")
                   .IsRequired();

            builder.Property(x => x.frequencia_Descricao)
                  .HasColumnName("FREQUENCIA_DESCRICAO")
                  .IsRequired();
        }
    }
}
