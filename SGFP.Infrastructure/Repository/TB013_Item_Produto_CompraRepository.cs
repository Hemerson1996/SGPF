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
    public class TB013_Item_Produto_CompraRepository : BaseRepository<TB013_Item_Produto_Compra>, ITB013_Item_Produto_CompraRepository
    {
        public TB013_Item_Produto_CompraRepository(AppSGPFContext context) : base(context)
        {
        }

        public async Task<List<TB013_Item_Produto_Compra>> GetAllFull()
        {
            return await _dbSet
                .Include(x => x.TB011_Categoria_Produto_Compras)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
