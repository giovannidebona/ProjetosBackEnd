using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Empresas_Classes
    {
        public int Id { get; set; }
        public int Empresaid { get; set; }
        public int Classeitemid { get; set; }
        public virtual Empresas Empresa { get; set; }
        public virtual Classes_Itens ClasseItem { get; set; }
    }
}
