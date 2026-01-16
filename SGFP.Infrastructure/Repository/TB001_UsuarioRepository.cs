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
    public class TB001_UsuarioRepository : BaseRepository<TB001_Usuario>, ITB001_UsuarioRepository
    {
        public TB001_UsuarioRepository(AppSGPFContext context) : base(context)
        {
        }

        public Task<TB001_Usuario> ObterPorEmail(string email)
        {
            return _dbSet.AsNoTracking().FirstOrDefaultAsync(x=> x.Email == email);
        }
    }
}
