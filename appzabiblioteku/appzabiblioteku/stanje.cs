using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appzabiblioteku
{
    class stanje
    {
        int id_knjige;
        int kolicina;

        public stanje(int id_knjige, int kolicina)
        {
            this.id_knjige = id_knjige;
            this.kolicina = kolicina;
        }

        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
