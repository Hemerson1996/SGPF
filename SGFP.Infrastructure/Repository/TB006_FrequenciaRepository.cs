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
    public class TB006_FrequenciaRepository : BaseRepository<TB006_Frequencia>,ITB006_FrequenciaRepository
    {
        public TB006_FrequenciaRepository(AppSGPFContext context) : base(context)
        {
        }
    }
}
