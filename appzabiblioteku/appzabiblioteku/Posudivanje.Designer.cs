
namespace appzabiblioteku
{
    partial class frm_posudivanje
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_korisnik = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_knjiga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 82);
            this.listBox1.TabIndex = 0;
            // 
            // lbl_korisnik
            // 
            this.lbl_korisnik.AutoSize = true;
            this.lbl_korisnik.Location = new System.Drawing.Point(22, 33);
            this.lbl_korisnik.Name = "lbl_korisnik";
            this.lbl_korisnik.Size = new System.Drawing.Size(47, 13);
            this.lbl_korisnik.TabIndex = 1;
            this.lbl_korisnik.Text = "Korisnik:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(244, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 82);
            this.listBox2.TabIndex = 2;
            // 
            // lbl_knjiga
            // 
            this.lbl_knjiga.AutoSize = true;
            this.lbl_knjiga.Location = new System.Drawing.Point(241, 33);
            this.lbl_knjiga.Name = "lbl_knjiga";
            this.lbl_knjiga.Size = new System.Drawing.Size(39, 13);
            this.lbl_knjiga.TabIndex = 3;
            this.lbl_knjiga.Text = "Knjiga:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Posudi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Location = new System.Drawing.Point(452, 333);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_izlaz.TabIndex = 14;
            this.btn_izlaz.Text = "Zatvori";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.btn_izlaz_Click);
            // 
            // frm_posudivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 397);
            this.Controls.Add(this.btn_izlaz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_knjiga);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbl_korisnik);
            this.Controls.Add(this.listBox1);
            this.Name = "frm_posudivanje";
            this.Text = "Posudba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_korisnik;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_knjiga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_izlaz;
    }
}