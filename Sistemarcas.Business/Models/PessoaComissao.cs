using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Pessoa_Comissao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int Pessoa_id { get; set; }
        public int Tipo_despacho_id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual TiposDespachos TipoDespacho { get; set; }
    }
}
