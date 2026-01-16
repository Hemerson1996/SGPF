using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Interfaces
{
    public interface ITB009_Tipo_DespesaRespository:IBaseRepository<TB009_Tipo_Despesa>
    {
        Task<List<TB009_Tipo_Despesa>> GetAllFull();
    }
}
