using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prøveeksamen_29042025

//Opgave 3.2 Klasser (60 min)

// isbn, udgivelsesår, titel, tegnerNavn og antalProduceret.
{
    internal class Album
    {
        public string Isbn { get; set; }
        public int Udgivelsesår { get; set; }
        public string Titel { get; set; }
        public string TegnerNavn { get; set; }
        public int AntalProduceret { get; set; }
        public Album(string isbn, int udgivelsesår, string titel, string tegnerNavn, int antalProduceret)
        {
            Isbn = isbn;
            Udgivelsesår = udgivelsesår;
            Titel = titel;
            TegnerNavn = tegnerNavn;
            AntalProduceret = antalProduceret;
        }
    }
}
