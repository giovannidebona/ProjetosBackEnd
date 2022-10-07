using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Permissoes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public short Ordem { get; set; }
        public short Codigopermissao { get; set; }
    }
}
