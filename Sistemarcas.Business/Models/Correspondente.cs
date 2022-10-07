using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Correspondentes
    {
        public int Id { get; set; }
        public int Pessoa_id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
