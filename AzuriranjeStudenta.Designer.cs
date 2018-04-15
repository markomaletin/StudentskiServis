namespace TVP_Projekat1
{
    partial class AzuriranjeStudenta
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
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.gpPodaci = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.cmbSmer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite studenta koji želite da ažurirate:";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.IntegralHeight = false;
            this.cmbStudenti.Location = new System.Drawing.Point(240, 29);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(281, 21);
            this.cmbStudenti.TabIndex = 2;
            this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbStudenti_SelectedIndexChanged);
            // 
            // gpPodaci
            // 
            this.gpPodaci.Controls.Add(this.label10);
            this.gpPodaci.Controls.Add(this.txtKorisnickoIme);
            this.gpPodaci.Controls.Add(this.label11);
            this.gpPodaci.Controls.Add(this.txtPassword);
            this.gpPodaci.Controls.Add(this.label7);
            this.gpPodaci.Controls.Add(this.txtJMBG);
            this.gpPodaci.Controls.Add(this.cmbSmer);
            this.gpPodaci.Controls.Add(this.label2);
            this.gpPodaci.Controls.Add(this.txtIme);
            this.gpPodaci.Controls.Add(this.txtTelefon);
            this.gpPodaci.Controls.Add(this.label6);
            this.gpPodaci.Controls.Add(this.label4);
            this.gpPodaci.Controls.Add(this.dtDatumRodjenja);
            this.gpPodaci.Controls.Add(this.txtPrezime);
            this.gpPodaci.Controls.Add(this.label5);
            this.gpPodaci.Controls.Add(this.label8);
            this.gpPodaci.Controls.Add(this.txtIndex);
            this.gpPodaci.Controls.Add(this.label9);
            this.gpPodaci.Controls.Add(this.label3);
            this.gpPodaci.Location = new System.Drawing.Point(45, 79);
            this.gpPodaci.Name = "gpPodaci";
            this.gpPodaci.Size = new System.Drawing.Size(473, 331);
            this.gpPodaci.TabIndex = 4;
            this.gpPodaci.TabStop = false;
            this.gpPodaci.Text = " Novi podaci: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Korisnicko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(136, 268);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(273, 20);
            this.txtKorisnickoIme.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 298);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Smer";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(136, 146);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(273, 20);
            this.txtJMBG.TabIndex = 12;
            // 
            // cmbSmer
            // 
            this.cmbSmer.FormattingEnabled = true;
            this.cmbSmer.Location = new System.Drawing.Point(136, 236);
            this.cmbSmer.Name = "cmbSmer";
            this.cmbSmer.Size = new System.Drawing.Size(273, 21);
            this.cmbSmer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(136, 86);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(273, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(136, 206);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(273, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Prezime";
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatumRodjenja.Location = new System.Drawing.Point(136, 173);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(273, 20);
            this.dtDatumRodjenja.TabIndex = 14;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(136, 116);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(273, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Datum rođenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Broj indeksa:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(136, 56);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(273, 20);
            this.txtIndex.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "JMBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Korisnik ne mora uneti sve podatke, već samo podatke koje zeli da promeni.";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(42, 433);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 11;
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(304, 461);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(207, 34);
            this.btnAzuriraj.TabIndex = 30;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 34);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AzuriranjeStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 515);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpPodaci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStudenti);
            this.Name = "AzuriranjeStudenta";
            this.Text = "AzuriranjeStudenta";
            this.Load += new System.EventHandler(this.AzuriranjeStudenta_Load);
            this.gpPodaci.ResumeLayout(false);
            this.gpPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.GroupBox gpPodaci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.ComboBox cmbSmer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDatumRodjenja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
    }
}