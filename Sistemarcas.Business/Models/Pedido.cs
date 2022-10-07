using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public string Numeropedido { get; set; }
        public short Situacao { get; set; }
        public int Clienteid { get; set; }
        public decimal Valorpedido { get; set; }
        public string Observacao { get; set; }
        public decimal Valordesconto { get; set; }
        public int Empresaid { get; set; }
        public bool Geradoautomatico { get; set; }
        public int Tipopedido { get; set; }
        public TimeSpan Datahora { get; set; }
        public int Vendedorid { get; set; }
        public int Convenioid { get; set; }
        public int Contaid { get; set; }
        public decimal Valorpermuta { get; set; }
        public bool Gerarnfe { get; set; }
        public DateTime Prazoautorizacao { get; set; }
        public short Prioridade { get; set; }
        public int Despachoid { get; set; }
        public bool Calcularprazoservicos { get; set; }
        public TimeSpan Dataautorizacao { get; set; }
        public int Pessoa_vendedor_id { get; set; }
        public decimal Valorliquido { get; set; }
    }
}
