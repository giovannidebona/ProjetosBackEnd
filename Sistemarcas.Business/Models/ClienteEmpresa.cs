using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class ClientesEmpresas
    {
        public int Id { get; set; }
        public int Clienteid { get; set; }
        public int Empresaid { get; set; }
        public int Cargoid { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empresas Empresa { get; set; }
        public virtual Cargos Cargo { get; set; }
    }
}
