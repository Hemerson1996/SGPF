using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Domain.Entities
{
    public class TB015_Status_Pagamentos
    {
        public int status_Pagamento_Id { get; set; }
        public string status_Pagamento_Nome { get; set; }
        public bool status_Pagamento_Status { get; set; }
        
        public virtual ICollection<TB010_Despesa> TB010_Despesas { get; set; }
    }
}
