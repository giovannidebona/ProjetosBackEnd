using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Instituicoes
    {
        public int Id { get; set; }
        public int Pessoa_id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
