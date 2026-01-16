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
    public class TB009_Tipo_DespesaRespository : BaseRepository<TB009_Tipo_Despesa>, ITB009_Tipo_DespesaRespository
    {
        public TB009_Tipo_DespesaRespository(AppSGPFContext context) : base(context)
        {
        }

        public async Task<List<TB009_Tipo_Despesa>> GetAllFull()
        {
            return await _dbSet
                .Include(x=>x.TB008_Categoria_Despesas)
                .AsNoTracking()
                .ToListAsync(); 
        }
    }
}
