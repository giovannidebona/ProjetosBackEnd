using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Contas
    {
        public int Id { get; set; }
        public int Clienteid { get; set; }
        public int Empresaid { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public int Vendedorid { get; set; }
        public int Convenioid { get; set; }
        public short Status { get; set; }
        public short Numeroparcelas { get; set; }
        public decimal Valorpermuta { get; set; }
        public int Pessoa_vendedor_id { get; set; }
    }
}
