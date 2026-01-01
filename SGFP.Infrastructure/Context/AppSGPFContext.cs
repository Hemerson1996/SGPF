using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Infrastructure.Context
{
    public class AppSGPFContext : DbContext
    {
        public AppSGPFContext(DbContextOptions<AppSGPFContext> options) : base(options)
        {
        }


        public DbSet<TB003_Categoria_Receita> TB003_Categoria_Receitas { get; set; }
        public DbSet<TB004_Tipo_Origem_Dinheiro> TB004_Tipo_Origem_Dinheiros { get; set; }
        public DbSet<TB005_Recebimento> TB005_Recebimentos { get; set; }
        public DbSet<TB006_Frequencia> TB006_Frequencias { get; set; }
        public DbSet<TB007_Receita> TB007_Receitas { get; set; }
        public DbSet<TB008_Categoria_Despesa> TB008_Categoria_Despesas { get; set; }
        public DbSet<TB009_Tipo_Despesa> TB009_Tipo_Despesas { get; set; }
        public DbSet<TB010_Despesa> TB010_Despesas { get; set; }
        public DbSet<TB011_Categoria_Produto_Compra> TB011_Categoria_Produto_Compras { get; set; }
        public DbSet<TB012_Unidade_Produto_Compra> TB012_Unidade_Produto_Compras { get; set; }
        public DbSet<TB013_Item_Produto_Compra> TB013_Item_Produto_Compras { get; set; }
        public DbSet<TB014_Item_Compra> TB014_Item_Compras { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
