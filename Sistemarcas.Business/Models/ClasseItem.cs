using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Classes_Itens
    {
        public int Id { get; set; }
        public string Classe { get; set; }
        public string Nome { get; set; }
        public string Numerobase { get; set; }
        public int Classeid { get; set; }
        public virtual Classes Classes { get; set; }
    }
}
