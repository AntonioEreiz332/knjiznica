using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appzabiblioteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_unosKorisnika_Click(object sender, EventArgs e)
        {
            frm_unosKorisnika UnosKorisnika = new frm_unosKorisnika();
            UnosKorisnika.ShowDialog();
        }

        private void btn_unosKnjiga_Click(object sender, EventArgs e)
        {
            frm_unosKnjiga UnosKnjiga = new frm_unosKnjiga();
            UnosKnjiga.ShowDialog();
        }

        private void btn_pretrazivanjePodataka_Click(object sender, EventArgs e)
        {
            frm_pretrazivanjePodataka PretrazivanjePodataka = new frm_pretrazivanjePodataka();
            PretrazivanjePodataka.ShowDialog();
        }

        private void btn_posudba_Click(object sender, EventArgs e)
        {
            frm_posudivanje Posudivanje = new frm_posudivanje();
            Posudivanje.ShowDialog();
        }
    }
}
