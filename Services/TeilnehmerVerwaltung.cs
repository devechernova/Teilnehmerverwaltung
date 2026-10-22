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

        public TeilnehmerVerwaltung()
        {
            TeilnehmerListe = new ObservableCollection<Teilnehmer>();
        }
    }
}
