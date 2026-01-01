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

            builder.Property(x => x.categoriaReceita_Id)
             .HasColumnName("CATEGORIA_RECEITA_ID")
             .IsRequired();

            builder.Property(x => x.categoriaReceita_Id)
           .HasColumnName("CATEGORIA_RECEITA_ID")
           .IsRequired();

            builder.Property(x => x.recebimento_Id)
             .HasColumnName("RECEBIMENTO_ID")
             .IsRequired();

            builder.Property(x => x.receita_Valor)
             .HasColumnName("RECEITA_VALOR")
             .HasColumnType("decimal(18,2)")
             .IsRequired();

            builder.HasOne(x=> x.TB003_Categoria_Receitas)
                .WithMany(x=>x.T007_Receitas)
                .HasForeignKey(x=>x.receita_Id)
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
