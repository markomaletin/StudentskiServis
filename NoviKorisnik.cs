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
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
            cmbSmer.DataSource = Smer.sviSmerovi();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                gbStudent.Visible = true;
                gbAdmin.Visible = false;
               
                
            }
            else
            {
                gbAdmin.Visible = true;
                //gbStudent.Visible = false;
                rbAdmin.Checked = true;
               
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(rbStudent.Checked)
            {
                string index = txtIndex.Text;
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string JMBG = txtJMBG.Text;
                string korIme = txtKorisnickoIme.Text;
                string pass = txtPasswordStudent.Text;

                DateTime datum;
                bool uspesno = DateTime.TryParse(dtDatumRodjenja.Text, out datum);

                bool uspesno1 = true;
                string telefon = txtTelefon.Text;
                foreach (char c in telefon)
                {
                    if (!Char.IsNumber(c))
                    {
                        uspesno = false;
                    }
                }

                Smer smer = (Smer)cmbSmer.SelectedItem;

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
                        txtPasswordStudent.ResetText();
                        txtTelefon.ResetText();
                        txtJMBG.ResetText();
                        txtIndex.ResetText();
                        cmbSmer.ResetText();
                        dtDatumRodjenja.ResetText();
                    }
                    else
                    {
                        lblPoruka.Text = "Student vec postoji!";
                        lblPoruka.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblPoruka.Text = "Greska, niste popunili sva polja ili ste pogresili prilikom unosa!";
                    lblPoruka.ForeColor = Color.Red;
                }
            }
        
            else if(rbAdmin.Checked)
            {
                if(!txtImeAdmin.Equals("") && !txtPassAdmin.Equals(""))
                {
                    Administratori admin = new Administratori(txtImeAdmin.Text, txtPassAdmin.Text);
                    if(Administratori.dodajAdministratora(admin))
                    {
                        lblPoruka.Text = "Napravili ste novi nalog.";
                        lblPoruka.ForeColor = Color.Blue;
                        txtImeAdmin.ResetText();
                        txtPassAdmin.ResetText();
                        rbAdmin.Checked = false;
                        gbAdmin.Visible = false;
                        gbStudent.Visible = false;
                    }
                    else
                    {
                        lblPoruka.Text = "Greska pri dodavanju!";
                        lblPoruka.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblPoruka.Text = "Greska, niste uneli sve podatke!";
                    lblPoruka.ForeColor = Color.Red;
                }
            }
            
        }
    }
}
