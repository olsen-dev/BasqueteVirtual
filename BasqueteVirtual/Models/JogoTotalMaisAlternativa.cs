using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class JogoTotalMaisAlternativa
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string MaisDe { get; set; }
        public string MenosDe { get; set; }
        public string Odds { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
