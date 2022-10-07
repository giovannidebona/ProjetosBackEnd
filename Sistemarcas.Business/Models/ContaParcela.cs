using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Contas_Parcelas
    {
        public int Id { get; set; }
        public int Contaid { get; set; }
        public decimal Valor { get; set; }
        public short Numeroparcela { get; set; }
        public short Status { get; set; }
        public int Formapagamentoid { get; set; }
        public DateTime Datavencimento { get; set; }

    }
}
