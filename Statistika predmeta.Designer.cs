namespace TVP_Projekat1
{
    partial class Statistika_predmeta
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
            this.cmbSmerovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberite smer:";
            // 
            // cmbSmerovi
            // 
            this.cmbSmerovi.FormattingEnabled = true;
            this.cmbSmerovi.IntegralHeight = false;
            this.cmbSmerovi.Location = new System.Drawing.Point(121, 29);
            this.cmbSmerovi.Name = "cmbSmerovi";
            this.cmbSmerovi.Size = new System.Drawing.Size(207, 21);
            this.cmbSmerovi.TabIndex = 9;
            this.cmbSmerovi.SelectedIndexChanged += new System.EventHandler(this.cmbSmerovi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoruka.Location = new System.Drawing.Point(382, 163);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(324, 20);
            this.lblPoruka.TabIndex = 12;
            this.lblPoruka.Text = "Nije izabran ni jedan predmet sa ovog smera!";
            this.lblPoruka.Visible = false;
            // 
            // Statistika_predmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 335);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSmerovi);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Statistika_predmeta";
            this.Text = "Statistika predmeta";
            this.Load += new System.EventHandler(this.Statistika_predmeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSmerovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoruka;
    }
}