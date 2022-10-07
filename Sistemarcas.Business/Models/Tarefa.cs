using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Tarefas
    {
        public int Id { get; set; }
        public int? Usuarioid { get; set; }
        public int Pedidoid { get; set; }
        public int Processoid { get; set; }
        public int Despachoid { get; set; }
        public int Financeiroid { get; set; }
        public TimeSpan Dataprevisaotermino { get; set; }
        public TimeSpan Datatermino { get; set; }
        public TimeSpan Datainicio { get; set; }
        public int Usuariocriadorid { get; set; }
        public string Descricao { get; set; }
        public short Status { get; set; }
        public short Servicoid { get; set; }
        public short Grupo { get; set; }
        public short Prioridade { get; set; }
        public string Codigotarefa { get; set; }
        public short Tipotarefaid { get; set; }
        public int Processo_peticaoid { get; set; }
        public int Pendentetarefaid { get; set; }
        public int Classeid { get; set; }
        public int Clienteid { get; set; }
        public int Empresaid { get; set; }
        public bool Transferencia { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual Despachos Despacho { get; set; }
        public virtual Usuario UsuarioCriador { get; set; }
        public virtual Servicos Servico { get; set; }
        public virtual TiposTarefas TipoTarefa { get; set; }
    }
}
