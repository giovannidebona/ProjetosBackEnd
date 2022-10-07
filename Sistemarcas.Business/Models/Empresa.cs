using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Empresas
    {
        public int Id { get; set; }
        public string Razaosocial { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Inscricaoestadual { get; set; }
        public int Cidadeid { get; set; }
        public string Endenreco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int Porteinpiid { get; set; }
        public int Porteanvisaid { get; set; }
        public int Portepoliciaid { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Responsavel_legal { get; set; }
        public bool Pre_cadastro { get; set; }
    }
}
