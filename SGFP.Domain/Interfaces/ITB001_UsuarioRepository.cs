using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Interfaces
{
    public interface ITB001_UsuarioRepository:IBaseRepository<TB001_Usuario>
    {
        Task<TB001_Usuario> ObterPorEmail(string email);
    }
}
