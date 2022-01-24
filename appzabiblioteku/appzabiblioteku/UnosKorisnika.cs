using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace appzabiblioteku
{
    public partial class frm_unosKorisnika : Form
    {
        public frm_unosKorisnika()
        {
            InitializeComponent();
        }

        int oib;
        string ime, prezime;
        

        private void btn_unesi_Click(object sender, EventArgs e)
        {
            oib = Convert.ToInt32(txtbox_oibb.Text);
            ime = txtbox_imee.Text;
            prezime = txtbox_prezimee.Text;

            korisnik Korisnik = new korisnik(oib,ime,prezime);

            var dokumentKorisnici = 
        }

        private void btn_izlazz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
