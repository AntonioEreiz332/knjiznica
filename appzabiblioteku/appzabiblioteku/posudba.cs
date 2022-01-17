using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appzabiblioteku
{
    class posudba
    {
        DateTime datum_p;
        DateTime datum_v;
        int id_knjige;
        int id_koris;

        public posudba(DateTime datum_p, DateTime datum_v, int id_knjige, int id_koris)
        {
            this.Datum_p = datum_p;
            this.Datum_v = datum_v;
            this.Id_knjige = id_knjige;
            this.Id_koris = id_koris;
        }

        public DateTime Datum_p { get => datum_p; set => datum_p = value; }
        public DateTime Datum_v { get => datum_v; set => datum_v = value; }
        public int Id_knjige { get => id_knjige; set => id_knjige = value; }
        public int Id_koris { get => id_koris; set => id_koris = value; }
    }
}
