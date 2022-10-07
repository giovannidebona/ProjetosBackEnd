using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class OpcoesGerais
    {
        public short Id { get; set; }
        public string Smtpemail { get; set; }
        public string Usuarioemail { get; set; }
        public string Senhaemail { get; set; }
        public int Portaemail { get; set; }
        public bool Sslemail { get; set; }
        public string Emailsgerenciais { get; set; }
        public string Emailsloginportal { get; set; }
        public string Emailssenhaportal { get; set; }
        public string Emailsdadosportal { get; set; }
        public string Caminhoarquivosportal { get; set; }
        public string Keygoogle { get; set; }
    }
}
