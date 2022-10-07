using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public long Cadastradopor { get; set; }
        public long Modificadopor { get; set; }
        public TimeSpan Cadastradoem { get; set; }
        public string Email { get; set; }
        public TimeSpan Modificadoem { get; set; }
        public string Password { get; set; }
        public short Tipo { get; set; }
        public int Pessoa_id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
