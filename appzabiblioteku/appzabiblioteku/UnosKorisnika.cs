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
        

        List<korisnik> korisnici = new List<korisnik>();

        private void btn_unesi_Click(object sender, EventArgs e)
        { 
            korisnik Korisnik = new korisnik(Convert.ToInt32(txtbox_oibb.Text), txtbox_imee.Text, txtbox_prezimee.Text);
            korisnici.Add(Korisnik);
            DialogResult result;

            txtbox_oibb.Clear();
            txtbox_imee.Clear();
            txtbox_prezimee.Clear();

            result = MessageBox.Show("Želite li nastaviti upisivati korisnike?", "Upozorenje", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.No)
            {

                
            }

        }

        private void frm_unosKorisnika_Load(object sender, EventArgs e)
        {
            var korisniciXml = new XDocument();
            var rootElem = new XElement("Korisnici");
            korisniciXml.Add(rootElem);
            foreach (korisnik in korisnici)
            {

            }
        }

        private void btn_izlazz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
