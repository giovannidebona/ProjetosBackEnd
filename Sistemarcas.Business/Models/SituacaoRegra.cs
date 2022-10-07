using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemarcas.Domain.Models
{
    public class Situacoes_Regras
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Condicao1_peticaoid { get; set; }
        public int Condicao1_situacaoid { get; set; }
        public int Condicao2_peticaoid { get; set; }
        public int Condicao2_situacaoid { get; set; }
        public int Condicao3_despachoid { get; set; }
        public int Condicao3_situacaoid { get; set; }
        public int Condicao3_dias { get; set; }
        public int Condicao3_aposdias_situacaoid { get; set; }
        public int Condicao4_despachoid { get; set; }
        public int Condicao4_situacaoid { get; set; }
        public int Condicao2_peticaoid2 { get; set; }
        public bool Usacondicao1 { get; set; }
        public bool Usacondicao2 { get; set; }
        public bool Usacondicao3 { get; set; }
        public bool Usacondicao4 { get; set; }
        public bool Usacondicao5 { get; set; }
        public bool Usacondicao6 { get; set; }
        public bool Usacondicao7 { get; set; }
        public int Condicao5_situacaoid { get; set; }
        public int Condicao6_situacaoid { get; set; }
        public int Condicao7_peticaoid { get; set; }
        public int Condicao7_situacaoid { get; set; }
        public int Condicao7_situacaoid2 { get; set; }
        public int Condicao7_peticaoid2 { get; set; }
    }
}
