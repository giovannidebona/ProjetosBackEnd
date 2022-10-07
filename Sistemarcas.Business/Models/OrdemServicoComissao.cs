using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Ordem_Servico_Comissoes
    {
        public int Id { get; set; }
        public int Ordem_servico_id { get; set; }
        public int Pessoa_id { get; set; }
        public decimal Valor { get; set; }
        public short Status { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
