using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Estudo_Viabilidade
    {
        public int Id { get; set; }
        public int Clienteid { get; set; }
        public int Empresaid { get; set; }
        public int Status { get; set; }
        public int Usuario_criador_id { get; set; }
        public TimeSpan Data_criacao { get; set; }
        public TimeSpan Data_conclusao { get; set; }
        public int Usuario_responsavel_id { get; set; }
        public short Parecer { get; set; }
        public int Ordem_servico_id { get; set; }
        public short Status_proposta_id { get; set; }
        public string Observacoes { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empresas Empresa { get; set; }
        public virtual Usuario UsuarioCriador { get; set; }
        public virtual Usuario UsuarioResponsavel { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual Status_Propostas StatusProposta { get; set; }
    }
}
