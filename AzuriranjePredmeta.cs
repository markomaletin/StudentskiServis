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
    public partial class AzuriranjePredmeta : Form
    {
        List<Predmet> predmeti;

        public AzuriranjePredmeta()
        {
            InitializeComponent();
            predmeti = Predmet.sviPredmeti();
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAzuriraj.Enabled = true;
            grpPodaci.Enabled = true;

            Predmet predmet = (Predmet)cmbPredmeti.SelectedItem;
            //popunjava podatke o predmetu
            txtESPB.Text = predmet.ESPB1.ToString();
            txtNaziv.Text = predmet.Naziv_predmeta;
            txtProfesor.Text = predmet.Profesor;

            if(predmet.Obavezan)
            {
                rbDA.Checked = true;
            }
            else rbNE.Checked = true;


            for (int i = 0; i < cmbSmer.Items.Count; i++)
            {
                if (cmbSmer.Items[i].ToString().Equals(predmet.Smer.ToString()))
                {
                    cmbSmer.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cmbSemestar.Items.Count; i++)
            {
                if (cmbSemestar.Items[i].ToString().Equals(predmet.Semestar.ToString()))
                {
                    cmbSemestar.SelectedIndex = i;
                }
            }


        }

        
        private void AzuriranjePredmeta_Load(object sender, EventArgs e)
        {
            
            List<Smer> smerovi = Smer.sviSmerovi();

            btnAzuriraj.Enabled = false;
            grpPodaci.Enabled = false;

            foreach(Predmet p in predmeti)
            {
                cmbPredmeti.Items.Add(p);
            }

            foreach (Smer s in smerovi)
            {
                cmbSmer.Items.Add(s);
            }

            for (int i = 1; i < 7; i++)
            {
                cmbSemestar.Items.Add(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            int broj = cmbPredmeti.SelectedIndex;
            Predmet predmet = (Predmet)cmbPredmeti.SelectedItem;

            //kopija predmeta
            Predmet novi_predmet =new Predmet(predmeti[broj]); 

            if(!txtNaziv.Text.Equals(""))
            {
                novi_predmet.Naziv_predmeta = txtNaziv.Text;
            }

            if(!cmbSmer.Text.Equals(""))
            {
                novi_predmet.Smer =(Smer) cmbSmer.SelectedItem;
            }

            if (!txtProfesor.Text.Equals(""))
            {
                novi_predmet.Profesor = txtProfesor.Text;
            }

            if (!txtESPB.Text.Equals(""))
            {
                int espb;
                if (Int32.TryParse(txtESPB.Text, out espb))
                {
                    novi_predmet.ESPB1 = espb;
                }
                else
                {
                    lblPorukaESPB.Text = "Greska, pogresan format!";
                    lblPorukaESPB.ForeColor = Color.Red;
                }
            }

            if (rbDA.Checked) novi_predmet.Obavezan = true;
            if (rbNE.Checked) novi_predmet.Obavezan = false;

            if (!cmbSemestar.Text.Equals(""))
            {
                novi_predmet.Semestar = (int)cmbSemestar.SelectedItem;
            }

            if (predmet.ToString().Equals(novi_predmet.ToString()))
            {
                lblPoruka.Text = "Nista niste promenili!";
                lblPoruka.ForeColor = Color.Red;
            }
            else
            {
                //azuriranje izbornih listi
                List<IzbornaLista> izborne_liste = IzbornaLista.listeSvihStudenata();

                for (int i = 0; i < izborne_liste.Count; i++)
                {
                    for (int j = 0; j < izborne_liste[i].Predmeti_studenta.Count; j++)
                    {
                        if (izborne_liste[i].Predmeti_studenta[j].ToString().Equals(predmet.ToString()))
                        {
                            izborne_liste[i].Predmeti_studenta[j] = novi_predmet;
                           
                        }
                    }
                }
                IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborne_liste);


                predmeti[broj] = novi_predmet;
                Predmet.azuriranjeBrisanjePredmeta(predmeti);
                lblPoruka.Text = "Uspesno ste izmenili predmet";
                lblPoruka.ForeColor = Color.Blue;

                cmbPredmeti.Items.RemoveAt(broj);
                cmbPredmeti.Items.Insert(broj, novi_predmet);
                grpPodaci.Enabled = false;
                btnAzuriraj.Enabled = false;

                txtESPB.ResetText();
                txtNaziv.ResetText();
                txtProfesor.ResetText();
                cmbSemestar.ResetText();
                cmbSmer.ResetText();
                cmbPredmeti.ResetText();

            }

        }

        private void txtESPB_TextChanged(object sender, EventArgs e)
        {
            if(txtESPB.Text.Equals(""))
            {
                lblPorukaESPB.Text = "";
            }
        }
    }
}
