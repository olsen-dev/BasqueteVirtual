using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class JogoTotalImparPar
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string Impar { get; set; }
        public string Par { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
