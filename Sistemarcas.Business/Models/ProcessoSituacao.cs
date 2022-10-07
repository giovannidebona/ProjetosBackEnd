using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Situacoes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public short Grupo { get; set; }
    }
}
