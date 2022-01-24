
namespace appzabiblioteku
{
    partial class frm_unosKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_prezimee = new System.Windows.Forms.TextBox();
            this.lbl_prezimee = new System.Windows.Forms.Label();
            this.txtbox_imee = new System.Windows.Forms.TextBox();
            this.lbl_imee = new System.Windows.Forms.Label();
            this.txtbox_oibb = new System.Windows.Forms.TextBox();
            this.lbl_oibb = new System.Windows.Forms.Label();
            this.btn_izlazz = new System.Windows.Forms.Button();
            this.btn_unesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_prezimee
            // 
            this.txtbox_prezimee.Location = new System.Drawing.Point(233, 254);
            this.txtbox_prezimee.Name = "txtbox_prezimee";
            this.txtbox_prezimee.Size = new System.Drawing.Size(240, 20);
            this.txtbox_prezimee.TabIndex = 18;
            // 
            // lbl_prezimee
            // 
            this.lbl_prezimee.AutoSize = true;
            this.lbl_prezimee.Location = new System.Drawing.Point(230, 238);
            this.lbl_prezimee.Name = "lbl_prezimee";
            this.lbl_prezimee.Size = new System.Drawing.Size(47, 13);
            this.lbl_prezimee.TabIndex = 17;
            this.lbl_prezimee.Text = "Prezime:";
            // 
            // txtbox_imee
            // 
            this.txtbox_imee.Location = new System.Drawing.Point(233, 202);
            this.txtbox_imee.Name = "txtbox_imee";
            this.txtbox_imee.Size = new System.Drawing.Size(240, 20);
            this.txtbox_imee.TabIndex = 16;
            // 
            // lbl_imee
            // 
            this.lbl_imee.AutoSize = true;
            this.lbl_imee.Location = new System.Drawing.Point(230, 186);
            this.lbl_imee.Name = "lbl_imee";
            this.lbl_imee.Size = new System.Drawing.Size(27, 13);
            this.lbl_imee.TabIndex = 15;
            this.lbl_imee.Text = "Ime:";
            // 
            // txtbox_oibb
            // 
            this.txtbox_oibb.Location = new System.Drawing.Point(233, 143);
            this.txtbox_oibb.Name = "txtbox_oibb";
            this.txtbox_oibb.Size = new System.Drawing.Size(240, 20);
            this.txtbox_oibb.TabIndex = 14;
            // 
            // lbl_oibb
            // 
            this.lbl_oibb.AutoSize = true;
            this.lbl_oibb.Location = new System.Drawing.Point(230, 126);
            this.lbl_oibb.Name = "lbl_oibb";
            this.lbl_oibb.Size = new System.Drawing.Size(28, 13);
            this.lbl_oibb.TabIndex = 13;
            this.lbl_oibb.Text = "OIB:";
            // 
            // btn_izlazz
            // 
            this.btn_izlazz.Location = new System.Drawing.Point(398, 298);
            this.btn_izlazz.Name = "btn_izlazz";
            this.btn_izlazz.Size = new System.Drawing.Size(75, 23);
            this.btn_izlazz.TabIndex = 19;
            this.btn_izlazz.Text = "Izlaz";
            this.btn_izlazz.UseVisualStyleBackColor = true;
            this.btn_izlazz.Click += new System.EventHandler(this.btn_izlazz_Click_1);
            // 
            // btn_unesi
            // 
            this.btn_unesi.Location = new System.Drawing.Point(233, 298);
            this.btn_unesi.Name = "btn_unesi";
            this.btn_unesi.Size = new System.Drawing.Size(75, 23);
            this.btn_unesi.TabIndex = 20;
            this.btn_unesi.Text = "Unesi";
            this.btn_unesi.UseVisualStyleBackColor = true;
            this.btn_unesi.Click += new System.EventHandler(this.btn_unesi_Click);
            // 
            // frm_unosKorisnika
            // 
            this.ClientSize = new System.Drawing.Size(702, 400);
            this.Controls.Add(this.btn_unesi);
            this.Controls.Add(this.btn_izlazz);
            this.Controls.Add(this.txtbox_prezimee);
            this.Controls.Add(this.lbl_prezimee);
            this.Controls.Add(this.txtbox_imee);
            this.Controls.Add(this.lbl_imee);
            this.Controls.Add(this.txtbox_oibb);
            this.Controls.Add(this.lbl_oibb);
            this.Name = "frm_unosKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_izlaz;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.TextBox txtbox_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.TextBox txtbox_prezime;
        private System.Windows.Forms.Label lbl_oib;
        private System.Windows.Forms.TextBox txtbox_oib;
        private System.Windows.Forms.TextBox txtbox_prezimee;
        private System.Windows.Forms.Label lbl_prezimee;
        private System.Windows.Forms.TextBox txtbox_imee;
        private System.Windows.Forms.Label lbl_imee;
        private System.Windows.Forms.TextBox txtbox_oibb;
        private System.Windows.Forms.Label lbl_oibb;
        private System.Windows.Forms.Button btn_izlazz;
        private System.Windows.Forms.Button btn_unesi;
    }
}