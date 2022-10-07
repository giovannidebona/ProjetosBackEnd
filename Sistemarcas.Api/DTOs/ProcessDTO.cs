using System;

namespace Sistemarcas.Api.DTO
{
    public class ProcessDTO
    {
        public int Id { get; set; }
        public string Numeroprocesso { get; set; }
        public int PedidoId { get; set; }
        public int Processosituacaoid { get; set; }
        public TimeSpan Datarenovacao { get; set; }
        public short Servicoid { get; set; }
        public short Tipo { get; set; }
        public int Processofilhoid { get; set; }
        public int Clienteid { get; set; }
        public int Empresaid { get; set; }
        public TimeSpan Datacriacao { get; set; }
        public int Situacaoregistroid { get; set; }
        public DateTime Data_ultimasituacao { get; set; }
        public bool ProcessoExterno { get; set; }
    }
}
