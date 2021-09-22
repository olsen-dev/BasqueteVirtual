using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class ResultadoEtotal
    {
        public int? Id { get; set; }
        public string Horario { get; set; }
        public string TimeMaisDe { get; set; }
        public string TimeMenosDe { get; set; }
        public string Odds { get; set; }
    }
}
