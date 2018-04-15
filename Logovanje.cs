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
    public partial class Logovanje : Form
    {
        public Logovanje()
        {
            InitializeComponent();
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            List<Studenti> studenti = Studenti.sviStudenti();
          

            foreach (Studenti s in studenti)
            {
                if (s.Korisnicko_ime.Equals(txtKorisnickoIme.Text) && s.Password.Equals(txtLozinka.Text))
                {
                    txtKorisnickoIme.ResetText();
                    txtLozinka.ResetText();
                    lblPoruka.ResetText();
                    cbPrikazLozinke.Checked = false;
                    KorisnikMeni meni = new KorisnikMeni(this,s);
                    meni.Show();
                    this.Hide();
                    return;


                }
                
            }
            lblPoruka.Text = "Pogrešni podaci! Pokušajte ponovo!";
            lblPoruka.ForeColor = Color.Red;


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            List<Administratori> admini = Administratori.sviAdministratori();
            Administratori prijava = new Administratori(txtKorisnickoIme.Text, txtLozinka.Text);

            foreach(Administratori a in admini)
            {
                if(a.Korisnicko_ime.Equals(prijava.Korisnicko_ime) && a.Password.Equals(prijava.Password))
                {
                    txtKorisnickoIme.ResetText();
                    txtLozinka.ResetText();
                    lblPoruka.ResetText();
                    cbPrikazLozinke.Checked = false;
                    MeniAdmin meni = new MeniAdmin(this, prijava);
                    meni.Show();
                    this.Hide();
                    return;

                }
            }

            lblPoruka.Text = "Pogrešni podaci! Pokušajte ponovo!";
            lblPoruka.ForeColor = Color.Red;

        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            NoviKorisnik novikorisnik = new NoviKorisnik();
            novikorisnik.ShowDialog();
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            lblPoruka.ResetText();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            lblPoruka.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPrikazLozinke.Checked)
            {
                txtLozinka.PasswordChar = '\0';
            }
            else txtLozinka.PasswordChar = '*';
        }
    }
}
