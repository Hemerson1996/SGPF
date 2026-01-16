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
    public class TB007_ReceitaMap : IEntityTypeConfiguration<TB007_Receita>
    {
        public void Configure(EntityTypeBuilder<TB007_Receita> builder)
        {
            builder.ToTable("TB007_RECEITA");
            builder.HasKey(x=>x.receita_Id);

            builder.Property(x => x.receita_Id)
                .HasColumnName("RECEITA_ID")
                .IsRequired();

            builder.Property(x => x.usuario_Id)
             .HasColumnName("USUARIO_ID")
             .IsRequired();

            builder.Property(x => x.tipo_Origem_Dinheiro_Id)
             .HasColumnName("TIPO_ORIGEM_DINHEIRO_ID")
             .IsRequired();

            builder.Property(x => x.frequencia_Id)
           .HasColumnName("FREQUENCIA_ID")
           .IsRequired();

            builder.Property(x => x.recebimento_Id)
             .HasColumnName("RECEBIMENTO_ID")
             .IsRequired();

            builder.Property(x => x.receita_Valor)
             .HasColumnName("RECEITA_VALOR")
             .HasColumnType("decimal(18,2)")
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

            builder.HasOne(x=> x.TB004_Tipo_Origem_Dinheiros)
                .WithMany(x=>x.TB007_Receitas)
                .HasForeignKey(x=>x.tipo_Origem_Dinheiro_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB006_Frequencias)
            .WithMany(x => x.TB007_Receitas)
            .HasForeignKey(x => x.frequencia_Id)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TB005_Recebimentos)
            .WithMany(x => x.TB007_Receitas)
            .HasForeignKey(x => x.recebimento_Id)
            .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
