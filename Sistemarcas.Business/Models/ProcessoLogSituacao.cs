using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Log_Situacoes
    {
        public int Id { get; set; }
        public int Processoid { get; set; }
        public int Situacaoid { get; set; }
        public TimeSpan Data { get; set; }
    }
}
