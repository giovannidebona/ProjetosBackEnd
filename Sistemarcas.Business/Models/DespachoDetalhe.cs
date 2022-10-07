using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Despachos_Detalhes
    {
        public int Id { get; set; }
        public int Despachoid { get; set; }
        public int Processoid { get; set; }
        public int Tipodespachoid { get; set; }
        public string Texto { get; set; }
        public DateTime Datainclusao { get; set; }
        public DateTime Inicioprazoordinario { get; set; }
        public DateTime Fimprazoordinario { get; set; }
        public DateTime Inicioprazoextraordinario { get; set; }
        public DateTime Fimprazoextraordinario { get; set; }
        public virtual Despachos Despacho { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual TiposDespachos TipoDespacho { get; set; }
    }
}
