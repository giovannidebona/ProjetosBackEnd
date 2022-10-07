using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class UsuarioPermissao
    {
        public int Id { get; set; }
        public int Usuarioid { get; set; }
        public int Moduloid { get; set; }
        public int Identidade { get; set; }
        public int Permissaoid { get; set; }
        public long Cadastradopor { get; set; }
        public TimeSpan Cadastradoem { get; set; }
        public TimeSpan Modificadoem { get; set; }
        public long Modificadopor { get; set; }
    }
}
