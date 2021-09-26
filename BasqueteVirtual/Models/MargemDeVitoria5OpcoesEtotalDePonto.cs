using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class MargemDeVitoria5OpcoesEtotalDePonto
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string NomeTime { get; set; }
        public string MaisDe { get; set; }
        public string MenosDe { get; set; }
        public string OddMaisDe { get; set; }
        public string OddMenosDe { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
