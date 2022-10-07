using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Status_Propostas
    {
        public short Id { get; set; }
        public string Nome { get; set; }
        public short Ativo { get; set; }
        public short Ordem { get; set; }
    }
}
