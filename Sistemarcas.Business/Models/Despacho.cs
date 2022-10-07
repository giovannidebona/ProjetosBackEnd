using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Despachos
    {
        public int Id { get; set; }
        public TimeSpan Datarevista { get; set; }
        public string Numerorevista { get; set; }
    }
}
