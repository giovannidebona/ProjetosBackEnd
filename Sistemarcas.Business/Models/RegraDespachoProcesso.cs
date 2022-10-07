using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Regras_Despachos_Processos
    {
        public int Id { get; set; }
        public short Regra_id { get; set; }
        public int Processo_Id { get; set; }
        public bool Ativo { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
