using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Servicos
    {
        public short Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public short Tipo { get; set; }
        public short Grupo { get; set; }
    }
}
