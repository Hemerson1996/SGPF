using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entities;
using SGFP.Domain.Interfaces;
using SGFP.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Infrastructure.Repository
{
    public class TB014_Item_CompraRepository : BaseRepository<TB014_Item_Compra>, ITB014_Item_CompraRepository
    {
        public TB014_Item_CompraRepository(AppSGPFContext context) : base(context)
        {
        }

        public async Task<List<TB014_Item_Compra>> GetAllFull()
        {
            return await _dbSet
                .Include(x => x.TB011_Categoria_Produto_Compras)
                .Include(x => x.TB012_Unidade_Produto_Compras)
                .Include(x => x.TB013_Item_Produto_Compra)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
