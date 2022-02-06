using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appzabiblioteku
{
    class korisnik
    {
        long id_oib;
        string ime;
        string prezime;

        public korisnik(long id_oib, string ime, string prezime)
        {
            this.id_oib = id_oib;
            this.ime = ime;
            this.prezime = prezime;
        }

        public long Id_oib { get => id_oib; set => id_oib = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
