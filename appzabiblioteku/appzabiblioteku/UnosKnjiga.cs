using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace appzabiblioteku
{
    public partial class frm_unosKnjiga : Form
    {
        List<knjige> knjige = new List<knjige>();
        static string putdokumenta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string xmldokument = ("Knjige.xml");
        static string path = Path.Combine(putdokumenta, xmldokument);
        public frm_unosKnjiga()
        {
            InitializeComponent();
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Unesi_Click(object sender, EventArgs e)
        {
            try {
                knjige Knjiga = new knjige(Convert.ToInt32(txtbox_isbnKnjige.Text), txtbox_nazivKnjige.Text, txtbox_autorKnjige.Text);
                knjige.Add(Knjiga);
                DialogResult result;

                txtbox_autorKnjige.Clear();
                txtbox_isbnKnjige.Clear();
                txtbox_nazivKnjige.Clear();

                result = MessageBox.Show("Želite li upisati još knjiga?", "Upozorenje", MessageBoxButtons.YesNo);
                if(result == DialogResult.No)
                {
                    try
                    {
                        var Knjige = XDocument.Load(path);
                        foreach (knjige knjiga in knjige)
                        {
                            var knjigax = new XElement("Knjiga",
                                new XElement("ISBN", knjiga.Id_isbn),
                                new XElement("Autor", knjiga.Autor),
                                new XElement("Naziv", knjiga.Naziv));
                            Knjige.Root.Add(knjigax);
                        }
                        Knjige.Save(path);

                    }catch(Exception gr)
                    {
                        var Knjige = new XDocument();
                        var rootelem = new XElement("Knjige");
                        Knjige.Add(rootelem);
                        foreach (knjige knjiga in knjige)
                        {
                            var knjigax = new XElement("Knjiga",
                                new XElement("ISBN", knjiga.Id_isbn),
                                new XElement("Autor", knjiga.Autor),
                                new XElement("Naziv", knjiga.Naziv));
                            Knjige.Root.Add(knjigax);
                        }
                        Knjige.Save(path);
                    }
                    knjige.Clear();
                    this.Close();
                }
            
            }catch(Exception ae)
            {
                MessageBox.Show(ae.ToString(), "Greška", MessageBoxButtons.OK);

            }
        }
    }
}
