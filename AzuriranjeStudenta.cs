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
    public partial class AzuriranjeStudenta : Form
    {

        List<Studenti> studenti = Studenti.sviStudenti();

        public AzuriranjeStudenta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AzuriranjeStudenta_Load(object sender, EventArgs e)
        {
            gpPodaci.Enabled = false;
            btnAzuriraj.Enabled = false;


             foreach(Studenti s in studenti)
             {
                 cmbStudenti.Items.Add(s);
             }

            List<Smer> smerovi = Smer.sviSmerovi();
            foreach (Smer s in smerovi)
            {
                cmbSmer.Items.Add(s);
            }

        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPoruka.ResetText();
            gpPodaci.Enabled = true;
            btnAzuriraj.Enabled = true;

            Studenti student = (Studenti)cmbStudenti.SelectedItem;

            txtIme.Text = student.Ime_studenta;
            txtPrezime.Text = student.Prezime_studenta;
            txtIndex.Text = student.Index;
            txtJMBG.Text = student.JMBG1;
            txtKorisnickoIme.Text = student.Korisnicko_ime;
            txtPassword.Text = student.Password;
            txtTelefon.Text = student.Telefon;
            dtDatumRodjenja.Value = student.Datum_rodjenja;

            for(int i=0; i<cmbSmer.Items.Count;i++)
            {
                if(cmbSmer.Items[i].ToString().Equals(student.Smer.ToString()))
                {
                    cmbSmer.SelectedIndex = i;
                }
            }

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            
            int broj = cmbStudenti.SelectedIndex;
            Studenti student = (Studenti)cmbStudenti.SelectedItem;
            Studenti novi_student = new Studenti(student);
            

            if(!txtIndex.Text.Equals(""))
            {
                novi_student.Index = txtIndex.Text;
            }

            if (!txtIme.Text.Equals(""))
            {
                novi_student.Ime_studenta = txtIme.Text;
            }

            if (!txtPrezime.Text.Equals(""))
            {
                novi_student.Prezime_studenta = txtPrezime.Text;
            }

            if (!txtKorisnickoIme.Text.Equals(""))
            {
                novi_student.Korisnicko_ime = txtKorisnickoIme.Text;
            }

            if (!txtPassword.Text.Equals(""))
            {
                novi_student.Password = txtPassword.Text;
            }

            if (!txtJMBG.Text.Equals(""))
            {
               
                foreach(char c in txtJMBG.Text)
                {
                    if(!Char.IsNumber(c))
                    {
                        lblPoruka.Text = "Greska, JMBG pogresno unet!";
                        lblPoruka.ForeColor = Color.Red;
                        return;
                    }
                }
                novi_student.JMBG1 = txtJMBG.Text;
            }

           
            DateTime pom2;
            bool uspesno = DateTime.TryParse(dtDatumRodjenja.Text, out pom2);
            if(uspesno) novi_student.Datum_rodjenja = pom2;

            if (!txtTelefon.Text.Equals(""))
            {

                foreach (char c in txtTelefon.Text)
                {
                    if (!Char.IsNumber(c))
                    {
                        lblPoruka.Text = "Greska, telefon pogresno unet!";
                        lblPoruka.ForeColor = Color.Red;

                        return;
                    }
                }
                novi_student.Telefon = txtTelefon.Text;
            }


            
            if(!student.Smer.Equals(cmbSmer.SelectedItem))
            {
                List<Smer> smerovi = Smer.sviSmerovi();
                novi_student.Smer = smerovi[cmbSmer.SelectedIndex];

            }


            if (studenti[broj].ToString().Equals(novi_student.ToString()))
            {
                lblPoruka.Text = "Nista niste promenili!";
                lblPoruka.ForeColor = Color.Red;
            }
            else
            {

                List<IzbornaLista> izborne_liste = IzbornaLista.listeSvihStudenata();

                for (int i=0; i<izborne_liste.Count; i++)
                {
                    if(izborne_liste[i].Student.ToString().Equals(student.ToString()))
                    {
                        izborne_liste[i].Student = novi_student;
                        break;
                    }
                }
                IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborne_liste);

                studenti[broj] = novi_student;
                Studenti.azurirajBrisanjeStudenta(studenti);
                lblPoruka.Text = "Uspesno ste izmenili studenta";
                lblPoruka.ForeColor = Color.Blue;
                cmbStudenti.Items.RemoveAt(broj);
                cmbStudenti.Items.Insert(broj, novi_student);
                gpPodaci.Enabled = false;
                btnAzuriraj.Enabled = false;

                txtIme.ResetText();
                txtPrezime.ResetText();
                txtJMBG.ResetText();
                txtKorisnickoIme.ResetText();
                txtPassword.ResetText();
                txtTelefon.ResetText();
                txtJMBG.ResetText();
                txtIndex.ResetText();
                cmbSmer.ResetText();
                cmbStudenti.ResetText();
                dtDatumRodjenja.ResetText();

            }




        }
    }
}
