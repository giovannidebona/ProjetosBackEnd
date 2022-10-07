using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class LogErros
    {
        public long Id { get; set; }
        public string Modulo { get; set; }
        public string Mensagem { get; set; }
        public int Empresaid { get; set; }
        public int Usuarioid { get; set; }
        public DateTime Datahora { get; set; }
    }
}
