using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class OrdemServico_Patentes
    {
        public int Id { get; set; }
        public int Ordemservicoid { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Prazoautorizacao { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
    }
}
