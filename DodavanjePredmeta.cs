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
    public partial class DodavanjePredmeta : Form
    {
        public DodavanjePredmeta()
        {
            InitializeComponent();
        }

        private void DodavanjePredmeta_Load(object sender, EventArgs e)
        {
            List<Smer> smerovi = Smer.sviSmerovi();
            foreach (Smer s in smerovi)
            {
                cmbSmer.Items.Add(s);
            }
            for (int i = 1; i < 7; i++)
            {
                cmbSemestar.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            string naziv= txtNaziv.Text;
            Smer smer = (Smer)cmbSmer.SelectedItem;
            string profesor = txtProfesor.Text;

            int espb;
            bool uspesno = Int32.TryParse(txtESPB.Text, out espb);

            bool obavezan;
            if (rbDA.Checked) obavezan = true;
            else obavezan = false;

            int semestar=0;
            bool uspesno1 = false;
            if (cmbSemestar.SelectedItem!=null)
            {
                semestar = (int)cmbSemestar.SelectedItem;
                uspesno1 = true;
            }
          

            if(!naziv.Equals("") && !smer.Ime_smera.Equals("") && uspesno && !profesor.Equals("") && uspesno1)
            {
               if (Predmet.dodajPredmet(new Predmet(naziv, smer, profesor, espb, obavezan, semestar)))
                {
                    lblPoruka.Text = "Dodali ste predmet.";
                    lblPoruka.ForeColor = Color.Blue;

                    txtESPB.ResetText();
                    txtNaziv.ResetText();
                    txtProfesor.ResetText();
                    cmbSemestar.ResetText();
                    cmbSmer.ResetText();
                     
                }
               else
                {
                    lblPoruka.Text = "Predmet već postoji!";
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
