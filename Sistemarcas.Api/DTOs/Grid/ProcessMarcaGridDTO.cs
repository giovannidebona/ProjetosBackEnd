using Sistemarcas.Domain.Models;
using System;

namespace Sistemarcas.Api.DTO
{
    public class ProcessMarcaGridDTO
    {
        public string Elementonominativo { get; set; }
        public short Tipo { get; set; }
        public short Logosituacao { get; set; }
        public string Logomarca { get; set; }
        public int Classeid { get; set; }
        public short Status { get; set; }
        public virtual Classes Classe { get; set; }

    }
}
