using System;
using System.Collections.Generic;

#nullable disable

namespace BasqueteVirtual.Models
{
    public partial class TotaldoJogoIntervalos10Ponto
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public string MenosDe180 { get; set; }
        public string De180Ate189 { get; set; }
        public string De190Ate199 { get; set; }
        public string De200Ate209 { get; set; }
        public string De210Ate219 { get; set; }
        public string De220Ate229 { get; set; }
        public string De230Ate239 { get; set; }
        public string De240Ate249 { get; set; }
        public string De250Ate259 { get; set; }
        public string MaisDe259 { get; set; }
        public DateTime? InsertData { get; set; }
    }
}
