using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teilnehmerverwaltung.Models
{
    public class Teilnehmer
    {
        public int TeilnehmerNr { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public Umschulung Umschulung { get; set; }
        public Kostentraeger Kostentraeger { get; set; }
    }
}

