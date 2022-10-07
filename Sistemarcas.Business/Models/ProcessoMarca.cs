using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Marcas
    {
        public int Id { get; set; }
        public int Processoid { get; set; }
        public string Elementonominativo { get; set; }
        public short Tipo { get; set; }
        public short Logosituacao { get; set; }
        public string Logomarca { get; set; }
        public string Situacaoespecial { get; set; }
        public string Resultados { get; set; }
        public string Conclusao { get; set; }
        public short Situacaoid { get; set; }
        public int Classeid { get; set; }
        public DateTime Inicioprazoordinario { get; set; }
        public DateTime Inicioprazoextraordinario { get; set; }
        public DateTime Fimprazoordinario { get; set; }
        public DateTime Fimprazoextraordinario { get; set; }
        public DateTime Datavigencia { get; set; }
        public short Status { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual Classes Classe { get; set; }
    }
}
