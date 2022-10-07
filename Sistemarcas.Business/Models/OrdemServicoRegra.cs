using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class OrdemServico_Regras
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Despachoid { get; set; }
        public int Peticaoid_ordinario { get; set; }
        public int Peticaoid_extraordinario { get; set; }
        public int Peticaoid_ordinario2 { get; set; }
        public int Peticaoid_extraordinario2 { get; set; }
        public virtual Despachos Despacho { get; set; }
    }
}
