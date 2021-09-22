using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class TimeTotai
    {
        public int? Id { get; set; }
        public string Horario { get; set; }
        public string NomeTime { get; set; }
        public string MaisDe { get; set; }
        public string MenosDe { get; set; }
        public string Odds { get; set; }
    }
}
