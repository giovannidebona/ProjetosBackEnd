using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Tarefas_Escritorio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public short Prioridade { get; set; }
        public DateTime Data_prazo { get; set; }
        public short Status { get; set; }
        public int Usuarioresponsavelid { get; set; }
        public TimeSpan Data_abertura { get; set; }
        public virtual Usuario UsuarioResponsavel { get; set; }
    }
}
