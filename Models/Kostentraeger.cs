using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teilnehmerverwaltung.Models
{
    public class Kostentraeger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ansprechpartner { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

