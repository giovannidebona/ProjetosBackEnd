using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class GruposPermissoesDetalhes
    {
        public int Id { get; set; }
        public int Permissaoid { get; set; }
        public int Grupopermissaoid { get; set; }
    }
}
