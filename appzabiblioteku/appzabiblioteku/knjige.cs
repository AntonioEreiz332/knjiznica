using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appzabiblioteku
{
    class knjige
    {
        int id_isbn;
        string naziv;
        string autor;

        public knjige(int id_isbn, string naziv, string autor)
        {
            this.id_isbn = id_isbn;
            this.naziv = naziv;
            this.autor = autor;
        }

        public int Id_isbn { get => id_isbn; set => id_isbn = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
