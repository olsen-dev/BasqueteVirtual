using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class ApostasNoJogo
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string NomeTime { get; set; }
        public string Handicap { get; set; }
        public string Total { get; set; }
        public string ParaGanhar { get; set; }
        public string Odds { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
