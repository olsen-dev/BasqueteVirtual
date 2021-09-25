using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class MargemDeVitoria5Opco
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string NomeTime { get; set; }
        public string De1Ate5 { get; set; }
        public string De6Ate10 { get; set; }
        public string De11Ate15 { get; set; }
        public string De16Ate20 { get; set; }
        public string MaisDe21 { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
