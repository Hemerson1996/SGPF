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
    public class TB005_RecebimentoMap : IEntityTypeConfiguration<TB005_Recebimento>
    {
        public void Configure(EntityTypeBuilder<TB005_Recebimento> builder)
        {
            builder.ToTable("TB005_RECEBIMENTO");
            builder.HasKey(x => x.recebimento_Id);

            builder.Property(x => x.recebimento_Id)
                   .HasColumnName("RECEBIMENTO_ID")
                   .IsRequired();

            builder.Property(x => x.recebimento_Nome)
                   .HasColumnName("RECEBIMENTO_NOME")
                   .IsRequired();

            builder.Property(x => x.recebimento_Descricao)
                  .HasColumnName("RECEBIMENTO_DESCRICAO")
                  .IsRequired();
        }
    }
}
