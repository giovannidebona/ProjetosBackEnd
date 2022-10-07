using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public int? Pedidoid { get; set; }
        public TimeSpan Datarenovacao { get; set; }
        public short Servicoid { get; set; }
        public short Tipo { get; set; }
        public int? Processofilhoid { get; set; }
        public string Numeroprocesso { get; set; }
        public int? Clienteid { get; set; }
        public int? Empresaid { get; set; }
        public TimeSpan Datacriacao { get; set; }
        public int? Situacaoregistroid { get; set; }
        public DateTime Data_ultimasituacao { get; set; }
        public bool ProcessoExterno { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual SituacoesRegistro SituacoesRegistro { get; set; }
        public virtual Servicos Servico { get; set; }
        public virtual Processos_Marcas Processo_Marca { get; set; }
        public virtual Empresas Empresa { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
