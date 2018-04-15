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
    public partial class IzbrisiSmer : Form
    {
        public IzbrisiSmer()
        {
            InitializeComponent();
        }

        List<Smer> smerovi = Smer.sviSmerovi();

        private void IzbrisiSmer_Load(object sender, EventArgs e)
        {
            btnIzbrisi.Enabled = false;
            foreach (Smer s in smerovi)
            {
                cmbSmerovi.Items.Add(s);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            Smer smer = (Smer)cmbSmerovi.SelectedItem;

            List<Predmet> predmeti = Predmet.sviPredmeti();
            foreach(Predmet p in predmeti)
            {
                if(p.Smer.ToString().Equals(smer.ToString()))
                {
                    brojac++;
                }
            }

            List<Studenti> studenti = Studenti.sviStudenti();
            foreach (Studenti s in studenti)
            {
                if (s.Smer.ToString().Equals(smer.ToString()))
                {
                    brojac++;
                }
            }

            if (brojac == 0)
            {
                smerovi.Remove(smer);
                Smer.azurirajBrisanjeSmer(smerovi);

                cmbSmerovi.Items.Remove(smer);
                lblPoruka.Text = "Smer je izbrisan!";
                lblPoruka.ForeColor = Color.Blue;
                btnIzbrisi.Enabled = false;
            }
            else
            {
                lblPoruka.Text = "Ne mozete izbrisati smer, morate prvo izbrisati sve predmete i studente sa smera!";
                lblPoruka.ForeColor = Color.Red;
            }

        }

        private void cmbSmerovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrisi.Enabled = true;
            lblPoruka.ResetText();
        }
    }
}
