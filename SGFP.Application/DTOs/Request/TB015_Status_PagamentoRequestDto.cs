using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.DTOs.Request
{
    public class TB015_Status_PagamentoRequestDto
    {
        public int status_Pagamento_Id { get; set; }
        public string status_Pagamento_Nome { get; set; }
        public bool status_Pagamento_Status { get; set; }
    }
}
