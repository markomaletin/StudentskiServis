namespace TVP_Projekat1
{
    partial class Logovanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnNoviKorisnik = new System.Windows.Forms.Button();
            this.cbPrikazLozinke = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(160, 64);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(229, 20);
            this.txtKorisnickoIme.TabIndex = 2;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(160, 97);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(229, 20);
            this.txtLozinka.TabIndex = 3;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(68, 211);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(324, 37);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Prijavite se kao administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Location = new System.Drawing.Point(68, 161);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(324, 37);
            this.btnKorisnik.TabIndex = 5;
            this.btnKorisnik.Text = "Prijavite se kao korisnik";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPoruka.Location = new System.Drawing.Point(112, 31);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 6;
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(341, 21);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(94, 23);
            this.btnNoviKorisnik.TabIndex = 7;
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.UseVisualStyleBackColor = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // cbPrikazLozinke
            // 
            this.cbPrikazLozinke.AutoSize = true;
            this.cbPrikazLozinke.Location = new System.Drawing.Point(160, 124);
            this.cbPrikazLozinke.Name = "cbPrikazLozinke";
            this.cbPrikazLozinke.Size = new System.Drawing.Size(93, 17);
            this.cbPrikazLozinke.TabIndex = 8;
            this.cbPrikazLozinke.Text = "Prikaži lozinku";
            this.cbPrikazLozinke.UseVisualStyleBackColor = true;
            this.cbPrikazLozinke.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.cbPrikazLozinke);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logovanje";
            this.Text = "Logovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnNoviKorisnik;
        private System.Windows.Forms.CheckBox cbPrikazLozinke;
    }
}

