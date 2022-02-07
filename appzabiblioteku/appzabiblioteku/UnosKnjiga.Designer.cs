
namespace appzabiblioteku
{
    partial class frm_unosKnjiga
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
            this.txtbox_isbnKnjige = new System.Windows.Forms.TextBox();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.txtbox_autorKnjige = new System.Windows.Forms.TextBox();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.txtbox_nazivKnjige = new System.Windows.Forms.TextBox();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.btn_Unesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_isbnKnjige
            // 
            this.txtbox_isbnKnjige.Location = new System.Drawing.Point(179, 221);
            this.txtbox_isbnKnjige.Name = "txtbox_isbnKnjige";
            this.txtbox_isbnKnjige.Size = new System.Drawing.Size(240, 20);
            this.txtbox_isbnKnjige.TabIndex = 12;
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(176, 205);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(35, 13);
            this.lbl_isbn.TabIndex = 11;
            this.lbl_isbn.Text = "ISBN:";
            // 
            // txtbox_autorKnjige
            // 
            this.txtbox_autorKnjige.Location = new System.Drawing.Point(179, 169);
            this.txtbox_autorKnjige.Name = "txtbox_autorKnjige";
            this.txtbox_autorKnjige.Size = new System.Drawing.Size(240, 20);
            this.txtbox_autorKnjige.TabIndex = 10;
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(176, 153);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(35, 13);
            this.lbl_autor.TabIndex = 9;
            this.lbl_autor.Text = "Autor:";
            // 
            // txtbox_nazivKnjige
            // 
            this.txtbox_nazivKnjige.Location = new System.Drawing.Point(179, 110);
            this.txtbox_nazivKnjige.Name = "txtbox_nazivKnjige";
            this.txtbox_nazivKnjige.Size = new System.Drawing.Size(240, 20);
            this.txtbox_nazivKnjige.TabIndex = 8;
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(176, 93);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(37, 13);
            this.lbl_naziv.TabIndex = 7;
            this.lbl_naziv.Text = "Naziv:";
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Location = new System.Drawing.Point(344, 270);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_izlaz.TabIndex = 13;
            this.btn_izlaz.Text = "Zatvori";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.btn_izlaz_Click);
            // 
            // btn_Unesi
            // 
            this.btn_Unesi.Location = new System.Drawing.Point(179, 270);
            this.btn_Unesi.Name = "btn_Unesi";
            this.btn_Unesi.Size = new System.Drawing.Size(75, 23);
            this.btn_Unesi.TabIndex = 14;
            this.btn_Unesi.Text = "Unesi";
            this.btn_Unesi.UseVisualStyleBackColor = true;
            this.btn_Unesi.Click += new System.EventHandler(this.btn_Unesi_Click);
            // 
            // frm_unosKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 397);
            this.Controls.Add(this.btn_Unesi);
            this.Controls.Add(this.btn_izlaz);
            this.Controls.Add(this.txtbox_isbnKnjige);
            this.Controls.Add(this.lbl_isbn);
            this.Controls.Add(this.txtbox_autorKnjige);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.txtbox_nazivKnjige);
            this.Controls.Add(this.lbl_naziv);
            this.Name = "frm_unosKnjiga";
            this.Text = "UnosKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_isbnKnjige;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.TextBox txtbox_autorKnjige;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.TextBox txtbox_nazivKnjige;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Button btn_izlaz;
        private System.Windows.Forms.Button btn_Unesi;
    }
}