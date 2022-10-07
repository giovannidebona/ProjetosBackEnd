using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int  Cidadeid { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public short Status { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Razao_social { get; set; }
        public string Fantasia { get; set; }
        public int Tipo { get; set; }
        public string Cnpj { get; set; }
        public string Sexo { get; set; }
        public string Naturalidade { get; set; }
        public short Estadocivilid { get; set; }
        public bool Internacional { get; set; }
        public string Documentoprofissional { get; set; }
        public string Nacionalidade { get; set; }
        public string Profissao { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Inscricao_estadual { get; set; }
        public string Senhaportal { get; set; }
        public bool Primeiroacessoportal { get; set; }
        public string Numero { get; set; }
    }
}
