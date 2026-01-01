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
    public class TB009_Tipo_DespesaMap : IEntityTypeConfiguration<TB009_Tipo_Despesa>
    {
        public void Configure(EntityTypeBuilder<TB009_Tipo_Despesa> builder)
        {
            builder.ToTable("TB009_TIPO_DESPESA");
            builder.HasKey(x => x.tipo_Despesa_Id);

            builder.Property(x => x.tipo_Despesa_Id)
                .HasColumnName("TIPO_DESPESA_ID")
                .IsRequired();

            builder.Property(x => x.tipo_Despesa_Nome)
                .HasColumnName("TIPO_DESPESA_NOME")
                .IsRequired();

            builder.Property(x => x.categoria_Despesa_Id)
               .HasColumnName("CATEGORIA_DESPESA_ID")
               .IsRequired();

            builder.HasOne(x => x.TB008_Categoria_Despesas)
                .WithMany(x => x.TB009_Tipo_Despesa)
                .HasForeignKey(x => x.categoria_Despesa_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
