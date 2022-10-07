using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Peticoes
    {
        public int Id { get; set; }
        public int Processoid { get; set; }
        public int Tipodespachoid { get; set; }
        public int Pedidoid { get; set; }
        public string Numeroprotocolo { get; set; }
        public TimeSpan Dataprotocolo { get; set; }
        public string Texto { get; set; }
        public int Prazoordinario { get; set; }
        public int Prazoextraordinario { get; set; }
        public decimal Custo { get; set; }
        public short Situacaopeticaoid { get; set; }
        public short Status { get; set; }
        public string Nossonumero { get; set; }
        public TimeSpan Datacriacao { get; set; }
        public string Numeroprocesso { get; set; }
        public DateTime Dataprazoordinario { get; set; }
        public DateTime Dataprazoextraordinario { get; set; }
        public int Despachodetalheid { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual TiposDespachos TipoDespacho { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
    }
}
