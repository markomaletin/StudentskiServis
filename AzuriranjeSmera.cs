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
    public partial class AzuriranjeSmera : Form
    {
        public AzuriranjeSmera()
        {
            InitializeComponent();
        }

        List<Smer> smerovi = Smer.sviSmerovi();

        private void AzuriranjeSmera_Load(object sender, EventArgs e)
        {

            btnAzuriraj.Enabled = false;
            grpPodaci.Enabled = false;
            foreach(Smer s in smerovi)
            {
                cmbSmerovi.Items.Add(s);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            Smer smer = (Smer)cmbSmerovi.SelectedItem;
             
            if ((!txtIme.Text.Equals("")) && (!txtIme.Text.ToUpper().Equals(smer.Ime_smera)))
            {
                foreach(Smer s in smerovi)
                {
                    if(s.Ime_smera.Equals(txtIme.Text.ToUpper()))
                    {
                        lblPoruka.Text = "Greška, podatak već postoji!";
                        lblPoruka.ForeColor = Color.Red;
                        return;
                    }
                }


                int broj = cmbSmerovi.SelectedIndex;

                
                Smer novi_smer= new Smer(txtIme.Text.ToUpper());

                //Menja smer za sve predmete koji su na tom semru
                List<Predmet> predmeti = Predmet.sviPredmeti();
                for (int i=0; i<predmeti.Count; i++)
                {
                    if (predmeti[i].Smer.ToString().Equals(smer.ToString()))
                    {
                        predmeti[i].Smer = novi_smer;
                    }
                }
                Predmet.azuriranjeBrisanjePredmeta(predmeti);

                //Menja smer za sve studente koji su na tom semru
                List<Studenti> studenti = Studenti.sviStudenti();
                for (int i= 0; i < studenti.Count; i++)
                {
                    if (studenti[i].Smer.ToString().Equals(smer.ToString()))
                    {
                        studenti[i].Smer = novi_smer;
                    }
                }
                Studenti.azurirajBrisanjeStudenta(studenti);


                smerovi.Remove(smer);
                cmbSmerovi.Items.Remove(smer);
                
                cmbSmerovi.Items.Insert(broj, novi_smer);
                smerovi.Insert(broj, novi_smer);



                lblPoruka.Text = "Uspesno ste izvrsili promenu!";
                lblPoruka.ForeColor = Color.Blue;
                Smer.azurirajBrisanjeSmer(smerovi);
                btnAzuriraj.Enabled = false;
                grpPodaci.Enabled = false;
                cmbSmerovi.ResetText();
                txtIme.ResetText();
                
                

            }
           else
            {
                lblPoruka.Text = "Greska, nije izmenjen ni jedan podatak!";
                lblPoruka.ForeColor = Color.Red;
            }


            
        }

        private void cmbSmerovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIme.Text = ((Smer)cmbSmerovi.SelectedItem).Ime_smera;
            grpPodaci.Enabled = true;
            btnAzuriraj.Enabled = true;
            lblPoruka.ResetText();
        }
    }
}
