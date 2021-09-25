using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class ResultadoDuplo
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string Confronto1 { get; set; }
        public string Confronto1Odd { get; set; }
        public string Confronto2 { get; set; }
        public string Confronto2Odd { get; set; }
        public string Confronto3 { get; set; }
        public string Confronto3Odd { get; set; }
        public string Confronto4 { get; set; }
        public string Confronto4Odd { get; set; }
        public string Confronto5 { get; set; }
        public string Confronto5Odd { get; set; }
        public string Confronto6 { get; set; }
        public string Confronto6Odd { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
