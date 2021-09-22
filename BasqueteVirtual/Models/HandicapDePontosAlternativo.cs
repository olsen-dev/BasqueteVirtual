using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class HandicapDePontosAlternativo
    {
        public int? Id { get; set; }
        public string Horario { get; set; }
        public string Nome { get; set; }
        public string Total { get; set; }
        public string Odds { get; set; }
    }
}
