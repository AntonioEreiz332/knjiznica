
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
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.txtbox_ime = new System.Windows.Forms.TextBox();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.txtbox_prezime = new System.Windows.Forms.TextBox();
            this.lbl_oib = new System.Windows.Forms.Label();
            this.txtbox_oib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Location = new System.Drawing.Point(343, 269);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_izlaz.TabIndex = 0;
            this.btn_izlaz.Text = "Zatvori";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.btn_izlaz_Click);
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(175, 98);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(27, 13);
            this.lbl_ime.TabIndex = 1;
            this.lbl_ime.Text = "Ime:";
            // 
            // txtbox_ime
            // 
            this.txtbox_ime.Location = new System.Drawing.Point(178, 115);
            this.txtbox_ime.Name = "txtbox_ime";
            this.txtbox_ime.Size = new System.Drawing.Size(240, 20);
            this.txtbox_ime.TabIndex = 2;
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(175, 158);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(47, 13);
            this.lbl_prezime.TabIndex = 3;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // txtbox_prezime
            // 
            this.txtbox_prezime.Location = new System.Drawing.Point(178, 174);
            this.txtbox_prezime.Name = "txtbox_prezime";
            this.txtbox_prezime.Size = new System.Drawing.Size(240, 20);
            this.txtbox_prezime.TabIndex = 4;
            // 
            // lbl_oib
            // 
            this.lbl_oib.AutoSize = true;
            this.lbl_oib.Location = new System.Drawing.Point(175, 210);
            this.lbl_oib.Name = "lbl_oib";
            this.lbl_oib.Size = new System.Drawing.Size(28, 13);
            this.lbl_oib.TabIndex = 5;
            this.lbl_oib.Text = "OIB:";
            // 
            // txtbox_oib
            // 
            this.txtbox_oib.Location = new System.Drawing.Point(178, 226);
            this.txtbox_oib.Name = "txtbox_oib";
            this.txtbox_oib.Size = new System.Drawing.Size(240, 20);
            this.txtbox_oib.TabIndex = 6;
            // 
            // frm_unosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 397);
            this.Controls.Add(this.txtbox_oib);
            this.Controls.Add(this.lbl_oib);
            this.Controls.Add(this.txtbox_prezime);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.txtbox_ime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.btn_izlaz);
            this.Name = "frm_unosKorisnika";
            this.Text = "Unos korisnika";
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
    }
}