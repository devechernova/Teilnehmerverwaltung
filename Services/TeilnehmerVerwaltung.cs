using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teilnehmerverwaltung.Models;

namespace Teilnehmerverwaltung.Services
{
    public class TeilnehmerVerwaltung
    {
        public ObservableCollection<Teilnehmer> TeilnehmerListe { get; set; }
        public List<Umschulung> Umschulungen { get; set; }
        public List<Kostentraeger> KostentraegerListe { get; set; }

        public TeilnehmerVerwaltung()
        {
            TeilnehmerListe = new ObservableCollection<Teilnehmer>();

            Umschulungen = new List<Umschulung>();

            KostentraegerListe = new List<Kostentraeger>(); 

            Umschulung nachtwache = new Umschulung
            {
                KursNr = 1,
                Bezeichnung = "Nachtwache und Grenzsicherung",
                Beginn = new DateTime(2025, 9, 1),
                Ende = new DateTime(2027, 8, 31),
                Raum = "Die Mauer"
            };

            Umschulung drachen = new Umschulung
            {
                KursNr = 2,
                Bezeichnung = "Drachenaufzucht und Flugtechnik",
                Beginn = new DateTime(2025, 9, 1),
                Ende = new DateTime(2027, 8, 31),
                Raum = "Drachenstein"
            };

            Umschulung weisseWanderer = new Umschulung
            {
                KursNr = 3,
                Bezeichnung = "Armee der Weißen Wanderer",
                Beginn = new DateTime(2025, 9, 1),
                Ende = new DateTime(2027, 8, 31),
                Raum = "Jenseits der Mauer"
            };

            Umschulungen.Add(nachtwache);
            Umschulungen.Add(drachen);
            Umschulungen.Add(weisseWanderer);

            Kostentraeger nachtkoenig = new Kostentraeger
            {
                Id = 1,
                Name = "Armee der Toten",
                Ansprechpartner = "Night King",
                Telefon = "000-WINTER"
            };

            Kostentraeger drachenkoenigin = new Kostentraeger
            {
                Id = 2,
                Name = "Haus Targaryen",
                Ansprechpartner = "Daenerys Targaryen",
                Telefon = "0800-DRACHE"
            };

            KostentraegerListe.Add(nachtkoenig);
            KostentraegerListe.Add(drachenkoenigin);

            TeilnehmerListe.Add(new Teilnehmer
            {
                TeilnehmerNr = 1,
                Vorname = "Jon",
                Nachname = "Snow",
                Geburtsdatum = new DateTime(1990, 1, 15),
                Email = "jon.snow@nachtwache.de",
                Status = "Aktiv",
                Umschulung = nachtwache,
                Kostentraeger = drachenkoenigin
            });

            TeilnehmerListe.Add(new Teilnehmer
            {
                TeilnehmerNr = 2,
                Vorname = "Arya",
                Nachname = "Stark",
                Geburtsdatum = new DateTime(1998, 5, 22),
                Email = "arya.stark@winterfell.de",
                Status = "Aktiv",
                Umschulung = drachen,
                Kostentraeger = drachenkoenigin
            });

            TeilnehmerListe.Add(new Teilnehmer
            {
                TeilnehmerNr = 3,
                Vorname = "Tyrion",
                Nachname = "Lannister",
                Geburtsdatum = new DateTime(1985, 11, 11),
                Email = "tyrion.lannister@koenigsmund.de",
                Status = "Aktiv",
                Umschulung = drachen,
                Kostentraeger = drachenkoenigin
            });

            TeilnehmerListe.Add(new Teilnehmer
            {
                TeilnehmerNr = 4,
                Vorname = "Hodor",
                Nachname = "Hodor",
                Geburtsdatum = new DateTime(1988, 7, 7),
                Email = "hodor@winterfell.de",
                Status = "Aktiv",
                Umschulung = nachtwache,
                Kostentraeger = nachtkoenig
            });

            TeilnehmerListe.Add(new Teilnehmer
            {
                TeilnehmerNr = 5,
                Vorname = "Night",
                Nachname = "King",
                Geburtsdatum = new DateTime(1000, 1, 1),
                Email = "night.king@beyondthewall.de",
                Status = "Aktiv",
                Umschulung = weisseWanderer,
                Kostentraeger = nachtkoenig
            });
        }
    }
}
