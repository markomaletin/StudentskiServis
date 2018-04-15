namespace TVP_Projekat1
{
    partial class DodajIzbornuListu
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
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.lblESPB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izaberite studenta za kod unosite izbornu listu";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(25, 373);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 26;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(386, 402);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 33);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(28, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Predmeti sa drugih smerova: ";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.IntegralHeight = false;
            this.cmbPredmeti.Location = new System.Drawing.Point(227, 79);
            this.cmbPredmeti.MaxDropDownItems = 20;
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(281, 21);
            this.cmbPredmeti.TabIndex = 2;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(249, 34);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(259, 21);
            this.cmbStudenti.TabIndex = 1;
            this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbStudenti_SelectedIndexChanged_1);
            // 
            // lblESPB
            // 
            this.lblESPB.AutoSize = true;
            this.lblESPB.ForeColor = System.Drawing.Color.Blue;
            this.lblESPB.Location = new System.Drawing.Point(294, 412);
            this.lblESPB.Name = "lblESPB";
            this.lblESPB.Size = new System.Drawing.Size(0, 13);
            this.lblESPB.TabIndex = 48;
            // 
            // DodajIzbornuListu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 476);
            this.Controls.Add(this.lblESPB);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "DodajIzbornuListu";
            this.Text = "DodajIzbornuListu";
            this.Load += new System.EventHandler(this.DodajIzbornuListu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label lblESPB;
    }
}