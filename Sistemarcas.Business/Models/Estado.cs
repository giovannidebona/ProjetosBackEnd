using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Estados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int Paisid { get; set; }
        public virtual Paises Pais { get; set; }
    }
}
