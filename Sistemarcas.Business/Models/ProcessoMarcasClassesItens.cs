using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Marcas_Classes_Itens
    {
        public int Id { get; set; }
        public int Processomarcaid { get; set; }
        public int Classeitemid { get; set; }
        public string Textolivre { get; set; }
        public virtual Processos_Marcas ProcessoMarca { get; set; }
        public virtual Classes_Itens ClasseItem { get; set; }
    }
}
