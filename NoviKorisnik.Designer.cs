namespace TVP_Projekat1
{
    partial class NoviKorisnik
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
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImeAdmin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPasswordStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.cmbSmer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(59, 29);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(62, 17);
            this.rbStudent.TabIndex = 0;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(219, 29);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(85, 17);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.Text = "Administrator";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Vrsta Naloga: ";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPoruka.Location = new System.Drawing.Point(34, 439);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 29;
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(239, 469);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(151, 33);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(30, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.gbAdmin);
            this.gbStudent.Controls.Add(this.label8);
            this.gbStudent.Controls.Add(this.txtKorisnickoIme);
            this.gbStudent.Controls.Add(this.label9);
            this.gbStudent.Controls.Add(this.txtPasswordStudent);
            this.gbStudent.Controls.Add(this.label7);
            this.gbStudent.Controls.Add(this.txtJMBG);
            this.gbStudent.Controls.Add(this.cmbSmer);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.txtIme);
            this.gbStudent.Controls.Add(this.txtTelefon);
            this.gbStudent.Controls.Add(this.label6);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.dtDatumRodjenja);
            this.gbStudent.Controls.Add(this.txtPrezime);
            this.gbStudent.Controls.Add(this.label5);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.txtIndex);
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Location = new System.Drawing.Point(30, 103);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(360, 322);
            this.gbStudent.TabIndex = 30;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = " Novi student: ";
            this.gbStudent.Visible = false;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.label10);
            this.gbAdmin.Controls.Add(this.txtImeAdmin);
            this.gbAdmin.Controls.Add(this.label11);
            this.gbAdmin.Controls.Add(this.txtPassAdmin);
            this.gbAdmin.Location = new System.Drawing.Point(0, 0);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(360, 322);
            this.gbAdmin.TabIndex = 31;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = " Novi administrator: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Korisnicko ime:";
            // 
            // txtImeAdmin
            // 
            this.txtImeAdmin.Location = new System.Drawing.Point(124, 58);
            this.txtImeAdmin.Name = "txtImeAdmin";
            this.txtImeAdmin.Size = new System.Drawing.Size(195, 20);
            this.txtImeAdmin.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Password:";
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(124, 88);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Size = new System.Drawing.Size(195, 20);
            this.txtPassAdmin.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Korisnicko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 244);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(195, 20);
            this.txtKorisnickoIme.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Password:";
            // 
            // txtPasswordStudent
            // 
            this.txtPasswordStudent.Location = new System.Drawing.Point(124, 274);
            this.txtPasswordStudent.Name = "txtPasswordStudent";
            this.txtPasswordStudent.Size = new System.Drawing.Size(195, 20);
            this.txtPasswordStudent.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Smer";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(124, 123);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(195, 20);
            this.txtJMBG.TabIndex = 8;
            // 
            // cmbSmer
            // 
            this.cmbSmer.FormattingEnabled = true;
            this.cmbSmer.Location = new System.Drawing.Point(124, 213);
            this.cmbSmer.Name = "cmbSmer";
            this.cmbSmer.Size = new System.Drawing.Size(195, 21);
            this.cmbSmer.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(124, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(195, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(124, 183);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 20);
            this.txtTelefon.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezime";
            // 
            // dtDatumRodjenja
            // 
            this.dtDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatumRodjenja.Location = new System.Drawing.Point(124, 150);
            this.dtDatumRodjenja.Name = "dtDatumRodjenja";
            this.dtDatumRodjenja.Size = new System.Drawing.Size(195, 20);
            this.dtDatumRodjenja.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(124, 93);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(195, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj indeksa:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(124, 33);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(195, 20);
            this.txtIndex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "JMBG";
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 514);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImeAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPasswordStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.ComboBox cmbSmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDatumRodjenja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label4;
    }
}