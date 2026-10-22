using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teilnehmerverwaltung.Models
{
    public class Umschulung
    {
        public int KursNr { get; set; }
        public string Bezeichnung { get; set; }
        public DateTime Beginn { get; set; }
        public DateTime Ende { get; set; }
        public string Raum { get; set; }
    }
}
