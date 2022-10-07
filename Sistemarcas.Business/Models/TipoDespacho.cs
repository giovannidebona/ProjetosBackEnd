using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class TiposDespachos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public short Prazoordinario { get; set; }
        public string Acao { get; set; }
        public short Tipo { get; set; }
        public short Grupo { get; set; }
        public decimal Custo { get; set; }
        public short Prazoextraordinario { get; set; }
        public string Codigo { get; set; }
        public int Processosituacaoidincluir { get; set; }
        public int Processosituacaoidautomatica { get; set; }
        public bool Alterarsituacaoaposprazo { get; set; }
        public int Prazodiasalterarsituacao { get; set; }
        public int Processosituacaoidautorizado { get; set; }
        public int Processosituacaoidnaoautorizado { get; set; }
        public decimal Custograndeporte { get; set; }
        public string Nomeicone { get; set; }
        public string Corfundoicone { get; set; }
        public string Coricone { get; set; }
        public decimal Taxa_pequeno_porte { get; set; }
        public decimal Taxa_grande_porte { get; set; }
    }
}
