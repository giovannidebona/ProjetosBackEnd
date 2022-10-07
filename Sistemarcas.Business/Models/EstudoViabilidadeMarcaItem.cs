using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Estudo_Viabilidade_Marcas_Itens
    {
        public int Id { get; set; }
        public int Estudo_viabilidade_marca_id { get; set; }
        public int Classe_item_id { get; set; }
        public string Texto_livre { get; set; }
        public short Parecer { get; set; }
        public bool Gerada_os { get; set; }
        public virtual Estudo_Viabilidade_Marcas EstudoViabilidadeMarca { get; set; }
        public virtual Classes_Itens ClasseItem { get; set; }
    }
}
