using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class MargemDeVitoria7Opco
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string NomeTime { get; set; }
        public string De1Ate2 { get; set; }
        public string De3Ate6 { get; set; }
        public string De7Ate9 { get; set; }
        public string De10Ate13 { get; set; }
        public string De14Ate16 { get; set; }
        public string De17Ate20 { get; set; }
        public string MaisDe21 { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
