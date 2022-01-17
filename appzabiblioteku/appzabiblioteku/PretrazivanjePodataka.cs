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
    public partial class frm_pretrazivanjePodataka : Form
    {
        public frm_pretrazivanjePodataka()
        {
            InitializeComponent();
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
