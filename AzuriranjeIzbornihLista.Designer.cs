namespace TVP_Projekat1
{
    partial class AzuriranjeIzbornihLista
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
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblESPB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(254, 24);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(253, 21);
            this.cmbStudenti.TabIndex = 1;
            this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.cmbStudenti_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Predmeti sa drugih smerova: ";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.IntegralHeight = false;
            this.cmbPredmeti.Location = new System.Drawing.Point(173, 69);
            this.cmbPredmeti.MaxDropDownItems = 20;
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(334, 21);
            this.cmbPredmeti.TabIndex = 2;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Izaberite studenta za kog ažurirate izbornu listu";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(33, 381);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 55;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(394, 410);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(113, 33);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(36, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblESPB
            // 
            this.lblESPB.AutoSize = true;
            this.lblESPB.ForeColor = System.Drawing.Color.Blue;
            this.lblESPB.Location = new System.Drawing.Point(321, 420);
            this.lblESPB.Name = "lblESPB";
            this.lblESPB.Size = new System.Drawing.Size(0, 13);
            this.lblESPB.TabIndex = 56;
            // 
            // AzuriranjeIzbornihLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 477);
            this.Controls.Add(this.lblESPB);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label1);
            this.Name = "AzuriranjeIzbornihLista";
            this.Text = "AzuriranjeIzbornihLista";
            this.Load += new System.EventHandler(this.AzuriranjeIzbornihLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblESPB;
    }
}