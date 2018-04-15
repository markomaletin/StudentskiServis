using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat1.Student
{
    public partial class DodajStudenta : Form
    {
        public DodajStudenta()
        {
            InitializeComponent();
        }

        List<Smer> smerovi = Smer.sviSmerovi();

        private void DodajStudenta_Load(object sender, EventArgs e)
        {
            
            foreach(Smer s in smerovi)
            {
                cmbSmer.Items.Add(s);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string index = txtIndex.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string JMBG = txtJMBG.Text;
            string korIme = txtKorisnickoIme.Text;
            string pass = txtPassword.Text;

            DateTime datum;
            bool uspesno = DateTime.TryParse(dtDatumRodjenja.Text, out datum);
            
            bool uspesno1 = true;
            string telefon = txtTelefon.Text;
            foreach(char c in telefon)
            {
                if(!Char.IsNumber(c))
                {
                    uspesno = false;
                }
            }

            Smer smer = (Smer) cmbSmer.SelectedItem;

            if (!index.Equals("") && !ime.Equals("") && !prezime.Equals("") && !JMBG.Equals("") && uspesno && uspesno1 && !smer.Ime_smera.Equals("") && !korIme.Equals("") && !pass.Equals(""))
            {
                if (Studenti.dodajStudenta(new Studenti(index, ime, prezime, JMBG, datum, telefon, smer, korIme, pass)))
                {
                    lblPoruka.Text = "Dodali ste studenta";
                    lblPoruka.ForeColor = Color.Blue;

                    txtIme.ResetText();
                    txtPrezime.ResetText();
                    txtJMBG.ResetText();
                    txtKorisnickoIme.ResetText();
                    txtPassword.ResetText();
                    txtTelefon.ResetText();
                    txtJMBG.ResetText();
                    txtIndex.ResetText();
                    cmbSmer.ResetText();
                    dtDatumRodjenja.ResetText();

                }
                else
                {
                    lblPoruka.Text = "Student već postoji!";
                    lblPoruka.ForeColor = Color.Red;
                }
            }
            else
            {
                lblPoruka.Text = "Greška, niste popunili sva polja ili ste pogrešili prilikom unosa!";
                lblPoruka.ForeColor = Color.Red;
            }
        }

        
    }
}
