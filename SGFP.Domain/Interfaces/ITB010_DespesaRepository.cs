using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Interfaces
{
    public interface ITB010_DespesaRepository:IBaseRepository<TB010_Despesa>
    {
        Task<List<TB010_Despesa>> GetAllFull();
    }
}
