using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Log_OrdemServico
    {
        public int Id { get; set; }
        public int Ordemservicoid { get; set; }
        public short Statusid { get; set; }
        public string Acao { get; set; }
        public string Descricao { get; set; }
    }
}
