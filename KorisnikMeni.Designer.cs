namespace TVP_Projekat1
{
    partial class KorisnikMeni
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
            this.lblESPB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.svi_predmeti_studenta = new System.Windows.Forms.CheckedListBox();
            this.lblPodaciStudenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblESPB
            // 
            this.lblESPB.AutoSize = true;
            this.lblESPB.ForeColor = System.Drawing.Color.Blue;
            this.lblESPB.Location = new System.Drawing.Point(311, 436);
            this.lblESPB.Name = "lblESPB";
            this.lblESPB.Size = new System.Drawing.Size(0, 13);
            this.lblESPB.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Predmeti sa drugih smerova: ";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.IntegralHeight = false;
            this.cmbPredmeti.Location = new System.Drawing.Point(244, 109);
            this.cmbPredmeti.MaxDropDownItems = 20;
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(281, 21);
            this.cmbPredmeti.TabIndex = 49;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(42, 397);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 52;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(403, 426);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(113, 33);
            this.btnIzmeni.TabIndex = 50;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(45, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // svi_predmeti_studenta
            // 
            this.svi_predmeti_studenta.FormattingEnabled = true;
            this.svi_predmeti_studenta.Location = new System.Drawing.Point(45, 165);
            this.svi_predmeti_studenta.Name = "svi_predmeti_studenta";
            this.svi_predmeti_studenta.Size = new System.Drawing.Size(480, 199);
            this.svi_predmeti_studenta.TabIndex = 55;
            this.svi_predmeti_studenta.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Svi_predmeti_studenta_ItemCheck);
            // 
            // lblPodaciStudenta
            // 
            this.lblPodaciStudenta.AutoSize = true;
            this.lblPodaciStudenta.Location = new System.Drawing.Point(44, 26);
            this.lblPodaciStudenta.Name = "lblPodaciStudenta";
            this.lblPodaciStudenta.Size = new System.Drawing.Size(0, 13);
            this.lblPodaciStudenta.TabIndex = 56;
            // 
            // KorisnikMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 481);
            this.Controls.Add(this.lblPodaciStudenta);
            this.Controls.Add(this.svi_predmeti_studenta);
            this.Controls.Add(this.lblESPB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnCancel);
            this.Name = "KorisnikMeni";
            this.Text = "KorisnikMeni";
            this.Load += new System.EventHandler(this.KorisnikMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblESPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox svi_predmeti_studenta;
        private System.Windows.Forms.Label lblPodaciStudenta;
    }
}