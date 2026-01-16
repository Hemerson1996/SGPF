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
    public class TB010_DespesaRepository : BaseRepository<TB010_Despesa>, ITB010_DespesaRepository
    {
        public TB010_DespesaRepository(AppSGPFContext context) : base(context)
        {
        }

        public async Task<List<TB010_Despesa>> GetAllFull()
        {
            return await _dbSet
                .Include(x => x.TB008_Categoria_Despesas)
                .Include(x =>x.TB006_Frequencia)
                .Include(x=>x.TB015_Status_Pagamento)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
