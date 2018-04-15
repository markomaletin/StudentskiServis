namespace TVP_Projekat1
{
    partial class AzuriranjeSmera
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
            this.cmbSmerovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.grpPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSmerovi
            // 
            this.cmbSmerovi.FormattingEnabled = true;
            this.cmbSmerovi.IntegralHeight = false;
            this.cmbSmerovi.Location = new System.Drawing.Point(232, 36);
            this.cmbSmerovi.Name = "cmbSmerovi";
            this.cmbSmerovi.Size = new System.Drawing.Size(207, 21);
            this.cmbSmerovi.TabIndex = 1;
            this.cmbSmerovi.SelectedIndexChanged += new System.EventHandler(this.cmbSmerovi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite smer koji želite da ažurirate:";
            // 
            // grpPodaci
            // 
            this.grpPodaci.Controls.Add(this.label3);
            this.grpPodaci.Controls.Add(this.txtIme);
            this.grpPodaci.Controls.Add(this.label2);
            this.grpPodaci.Enabled = false;
            this.grpPodaci.Location = new System.Drawing.Point(40, 90);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(399, 114);
            this.grpPodaci.TabIndex = 4;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = " Novi podaci: ";
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
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(91, 51);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(176, 20);
            this.txtIme.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv smera:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 34);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(306, 246);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(133, 34);
            this.btnAzuriraj.TabIndex = 20;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(44, 218);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 8;
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AzuriranjeSmera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 303);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPodaci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSmerovi);
            this.Name = "AzuriranjeSmera";
            this.Text = "AzuriranjeSmera";
            this.Load += new System.EventHandler(this.AzuriranjeSmera_Load);
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSmerovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label lblPoruka;
    }
}