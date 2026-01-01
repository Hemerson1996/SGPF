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
    public class TB010_DespesaMap : IEntityTypeConfiguration<TB010_Despesa>
    {
        public void Configure(EntityTypeBuilder<TB010_Despesa> builder)
        {
            builder.ToTable("TB010_DESPESA");
            builder.HasKey(x => x.despesa_Id);

            builder.Property(x => x.despesa_Id)
                .HasColumnName("DESPESA_ID")
                .IsRequired();

            builder.Property(x => x.usuario_Id)
                .HasColumnName("USUARIO_ID")
                .IsRequired();

            builder.Property(x => x.categoria_Despesa_Id)
                .HasColumnName("CATEGORIA_DESPESA_ID")
                .IsRequired();

            builder.Property(x => x.despesa_Descricao)
                .HasColumnName("DESPESA_DESCRICAO")
                .HasMaxLength(255)
                .IsRequired();


            builder.Property(x => x.despesa_Valor)
                .HasColumnName("DESPESA_VALOR")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(x => x.data_Vencimento)
                .HasColumnName("DATA_VENCIMENTO")
                .IsRequired();

            builder.HasOne(x => x.TB008_Categoria_Despesas)
                 .WithMany(x => x.TB011_Despesas)
                 .HasForeignKey(x => x.categoria_Despesa_Id)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
