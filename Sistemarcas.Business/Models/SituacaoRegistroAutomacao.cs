using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class SituacoesRegistro_Automatizacoes
    {
        public int Id { get; set; }
        public int Tipodespachoid { get; set; }
        public int Situacaoregistroid { get; set; }
        public virtual TiposDespachos TiposDespachos { get; set; }
        public virtual SituacoesRegistro SituacoesRegistro { get; set; }
    }
}
