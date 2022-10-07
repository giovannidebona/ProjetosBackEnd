using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Tarefas_Responsaveis
    {
        public int Id { get; set; }
        public int Usuarioid { get; set; }
        public int Tarefaid { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Tarefas Tarefa { get; set; }
    }
}
