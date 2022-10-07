using Sistemarcas.Domain.Models;
using System;

namespace Sistemarcas.Api.DTO
{
    public class ProcessGridDTO
    {
        public int Id { get; set; }
        public string Numeroprocesso { get; set; }
        public string Elementonominativo { get; set; }
        public short Tipo { get; set; }
        public DateTime Prioridade { get; set; }
        public string NCL { get; set; }
        public string Titular { get; set; }
        public string Situacao { get; set; }
        public string Apresentacao
        {
            get
            {
                if (Tipo == 1) return "N";
                else if (Tipo == 2) return "B";
                else return "A";
            }
        }
        public ProcessMarcaGridDTO Processo_Marca { get; set; }
        public virtual OrdemServico OrdemServico { get; set; }
        public virtual Empresas Empresa { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual SituacoesRegistro SituacoesRegistro { get; set; }
    }
}
