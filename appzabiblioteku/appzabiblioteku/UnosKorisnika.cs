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
using System.IO;

namespace appzabiblioteku
{
    public partial class frm_unosKorisnika : Form
    {
        
        public frm_unosKorisnika()
        {
            InitializeComponent();
            

        }
        

        List<korisnik> korisnici = new List<korisnik>();
        static string putdokumenta =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string xmldokument = ("Korisnici.xml");
        static string path = Path.Combine(putdokumenta, xmldokument);
        private void btn_unesi_Click(object sender, EventArgs e)
        {

            try
            {
                korisnik Korisnik = new korisnik(Convert.ToInt64(txtbox_oibb.Text), txtbox_imee.Text, txtbox_prezimee.Text);
                korisnici.Add(Korisnik);
                DialogResult result;

                txtbox_oibb.Clear();
                txtbox_imee.Clear();
                txtbox_prezimee.Clear();

                result = MessageBox.Show("Želite li nastaviti upisivati korisnike?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    try
                    {
                        var korisnicii = XDocument.Load(path);
                        foreach (korisnik korisnik in korisnici)
                        {
                            var korisnikx = new XElement("Korisnik",
                            new XElement("OIB", korisnik.Id_oib),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime));
                            korisnicii.Root.Add(korisnikx);
                        }
                        korisnicii.Save(path);

                    }catch(Exception ae)
                    {
                        var korisnicii = new XDocument();
                        var rootelem = new XElement("Korisnici");
                        korisnicii.Add(rootelem);
                        foreach (korisnik korisnik in korisnici)
                        {
                            var korisnikx = new XElement("Korisnik",
                            new XElement("OIB", korisnik.Id_oib),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime));
                            korisnicii.Root.Add(korisnikx);
                        }
                        korisnicii.Save(path);

                    }
                    korisnici.Clear();
                    this.Close();
                }

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.ToString());
            }

        }

        private void frm_unosKorisnika_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_izlazz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
