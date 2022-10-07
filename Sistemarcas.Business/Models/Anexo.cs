using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Anexos
    {
        public int Id { get; set; }
        public int Processopeticaoid { get; set; }
        public int Processoid { get; set; }
        public string Nome { get; set; }
        public TimeSpan Data { get; set; }
        public int Despachoid { get; set; }
        public int Despachodetalheid { get; set; }
        public int Tarefaid { get; set; }
        public int Clienteid { get; set; }
        public short Categoriaanexoid { get; set; }
        public int Pedidoid { get; set; }
        public int Empresaid { get; set; }
        public int Usuario_criador_id { get; set; }
        public int Estudo_viabilidade_id { get; set; }
    }
}
