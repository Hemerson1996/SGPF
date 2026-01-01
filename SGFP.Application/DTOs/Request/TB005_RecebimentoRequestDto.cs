using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB005_RecebimentoRequestDto
    {
        public int recebimento_Id { get; set; }
        public string recebimento_Nome { get; set; }
        public string recebimento_Descricao { get; set; }
    }
}
