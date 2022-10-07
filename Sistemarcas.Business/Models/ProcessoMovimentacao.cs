using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Movimentacoes
    {
        public int Id { get; set; }
        public int Processopeticaoid { get; set; }
        public TimeSpan Datahora { get; set; }
        public short Status { get; set; }
        public string Descricao { get; set; }
        public short Tipo { get; set; }
        public int Tarefaid { get; set; }
        public virtual Processos_Peticoes ProcessoPeticao { get; set; }
        public virtual Tarefas Tarefa { get; set; }
    }
}
