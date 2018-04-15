using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat1
{
    public partial class DodavanjeSmer : Form
    {
        public DodavanjeSmer()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
                if (Smer.dodajSmer(txtUnos.Text.ToUpper()))
                {
                    lblPoruka.Text = "Smer je dodat.";
                    lblPoruka.ForeColor = Color.Blue;
                    txtUnos.ResetText();
                }
                else
                {
                    lblPoruka.Text = "Smer već postoji!";
                    lblPoruka.ForeColor = Color.Red;
                }
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUnos_TextChanged(object sender, EventArgs e)
        {
            if (!txtUnos.Text.Equals(""))
            {
                btnDodaj.Enabled = true;
            }else btnDodaj.Enabled = false;
        }

        private void DodavanjeSmer_Load(object sender, EventArgs e)
        {
            btnDodaj.Enabled = false;
        }
    }
}
