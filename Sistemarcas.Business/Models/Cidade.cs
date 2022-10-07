using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Codigo_ibge { get; set; }
        public int Estadoid { get; set; }
        public int Populacao_2010 { get; set; }
        public decimal Densidade_demo { get; set; }
        public string Gentilico { get; set; }
        public decimal Area { get; set; }
        public virtual Estados Estado { get; set; }
    }
}
