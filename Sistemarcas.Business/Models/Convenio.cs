using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Convenios
    {
        public int Id { get; set; }
        public int Empresaid { get; set; }
        public string Nome { get; set; }
        public decimal Desconto { get; set; }
    }
}
