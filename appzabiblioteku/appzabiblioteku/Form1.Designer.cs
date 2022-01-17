
namespace appzabiblioteku
{
    partial class Form1
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
            this.btn_unosKorisnika = new System.Windows.Forms.Button();
            this.btn_unosKnjiga = new System.Windows.Forms.Button();
            this.btn_pretrazivanjePodataka = new System.Windows.Forms.Button();
            this.btn_posudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_unosKorisnika
            // 
            this.btn_unosKorisnika.Location = new System.Drawing.Point(309, 113);
            this.btn_unosKorisnika.Name = "btn_unosKorisnika";
            this.btn_unosKorisnika.Size = new System.Drawing.Size(162, 49);
            this.btn_unosKorisnika.TabIndex = 0;
            this.btn_unosKorisnika.Text = "Unos korisnika";
            this.btn_unosKorisnika.UseVisualStyleBackColor = true;
            this.btn_unosKorisnika.Click += new System.EventHandler(this.btn_unosKorisnika_Click);
            // 
            // btn_unosKnjiga
            // 
            this.btn_unosKnjiga.Location = new System.Drawing.Point(309, 168);
            this.btn_unosKnjiga.Name = "btn_unosKnjiga";
            this.btn_unosKnjiga.Size = new System.Drawing.Size(162, 49);
            this.btn_unosKnjiga.TabIndex = 1;
            this.btn_unosKnjiga.Text = "Unos knjiga";
            this.btn_unosKnjiga.UseVisualStyleBackColor = true;
            this.btn_unosKnjiga.Click += new System.EventHandler(this.btn_unosKnjiga_Click);
            // 
            // btn_pretrazivanjePodataka
            // 
            this.btn_pretrazivanjePodataka.Location = new System.Drawing.Point(309, 223);
            this.btn_pretrazivanjePodataka.Name = "btn_pretrazivanjePodataka";
            this.btn_pretrazivanjePodataka.Size = new System.Drawing.Size(162, 49);
            this.btn_pretrazivanjePodataka.TabIndex = 2;
            this.btn_pretrazivanjePodataka.Text = "Pretrazivanje podataka";
            this.btn_pretrazivanjePodataka.UseVisualStyleBackColor = true;
            this.btn_pretrazivanjePodataka.Click += new System.EventHandler(this.btn_pretrazivanjePodataka_Click);
            // 
            // btn_posudba
            // 
            this.btn_posudba.Location = new System.Drawing.Point(309, 278);
            this.btn_posudba.Name = "btn_posudba";
            this.btn_posudba.Size = new System.Drawing.Size(162, 49);
            this.btn_posudba.TabIndex = 3;
            this.btn_posudba.Text = "Posudba";
            this.btn_posudba.UseVisualStyleBackColor = true;
            this.btn_posudba.Click += new System.EventHandler(this.btn_posudba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_posudba);
            this.Controls.Add(this.btn_pretrazivanjePodataka);
            this.Controls.Add(this.btn_unosKnjiga);
            this.Controls.Add(this.btn_unosKorisnika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_unosKorisnika;
        private System.Windows.Forms.Button btn_unosKnjiga;
        private System.Windows.Forms.Button btn_pretrazivanjePodataka;
        private System.Windows.Forms.Button btn_posudba;
    }
}

