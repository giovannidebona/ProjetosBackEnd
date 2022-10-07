using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Pedidos_Anexos
    {
        public int Id { get; set; }
        public string Nomearquivo { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
    }
}
