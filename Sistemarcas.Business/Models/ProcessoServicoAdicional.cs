using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Processos_Servicos_Adicionais
    {
        public int Id { get; set; }
        public int Processomarcaid { get; set; }
        public short Servicoid { get; set; }
        public virtual Processos_Marcas ProcessoMarca { get; set; }
        public virtual Servicos Servico { get; set; }
    }
}
