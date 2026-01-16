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

            builder.Property(x => x.frequencia_Id)
               .HasColumnName("FREQUENCIA_ID")
               .IsRequired();

            builder.Property(x => x.despesa_Descricao)
                .HasColumnName("DESPESA_DESCRICAO")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.status_Pagamento_Id)
                .HasColumnName("STATUS_PAGAMENTO_ID")
                .HasMaxLength(255)
                .IsRequired();


            builder.Property(x => x.despesa_Valor)
                .HasColumnName("DESPESA_VALOR")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(x => x.data_Vencimento)
                .HasColumnName("DATA_VENCIMENTO")
                .IsRequired();

            builder.Property(x => x.data_Inicio)
                 .HasColumnName("DATA_INICIO")
                 .IsRequired();

            builder.Property(x => x.data_Fim)
             .HasColumnName("DATA_FIM")
             .IsRequired();

            builder.Property(x => x.ativo)
            .HasColumnName("ATIVO")
            .IsRequired();

            builder.HasOne(x => x.TB008_Categoria_Despesas)
                 .WithMany(x => x.TB010_Despesas)
                 .HasForeignKey(x => x.categoria_Despesa_Id)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB006_Frequencia)
                 .WithMany(x => x.TB010_Despesas)
                 .HasForeignKey(x => x.frequencia_Id)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB015_Status_Pagamento)
                 .WithMany(x => x.TB010_Despesas)
                 .HasForeignKey(x => x.status_Pagamento_Id)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
