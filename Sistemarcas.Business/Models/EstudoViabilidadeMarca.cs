using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Estudo_Viabilidade_Marcas
    {
        public int Id { get; set; }
        public int Estudo_viabilidade_id { get; set; }
        public string Marca { get; set; }
        public string Segmento { get; set; }
        public virtual Estudo_Viabilidade EstudoViabilidade { get; set; }
    }
}
