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
    public class TB004_Tipo_Origem_DinheiroRepository : BaseRepository<TB004_Tipo_Origem_Dinheiro>, ITB004_Tipo_Origem_DinheiroRepository
    {
        public TB004_Tipo_Origem_DinheiroRepository(AppSGPFContext context) : base(context)
        {
            
        }

        public async Task<List<TB004_Tipo_Origem_Dinheiro>> ObteTodosComRelacionamento()
        {
            return await _dbSet
                .Include(x=>x.TB003_Categoria_Receita)
                .ToListAsync();
        }
    }
}
