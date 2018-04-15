using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat1.Student;

namespace TVP_Projekat1
{
    public partial class MeniAdmin : Form
    {
        Logovanje log;

        public MeniAdmin()
        {
            InitializeComponent();
        }

        public MeniAdmin(Logovanje log, Administratori admin)
        {
            InitializeComponent();
            this.log = log;
            lblAdmin.Text = "Trenutno je prijavljen administarator: "+ admin.Korisnicko_ime;

        }

        private void btnDodajSmer_Click(object sender, EventArgs e)
        {
            DodavanjeSmer dodavanje = new DodavanjeSmer();
            dodavanje.ShowDialog();
        }

        private void btnAzurirajSmer_Click(object sender, EventArgs e)
        {
            AzuriranjeSmera azuriranje= new AzuriranjeSmera();
            azuriranje.ShowDialog();
        }

        private void btnIzbrisiSmer_Click(object sender, EventArgs e)
        {
            IzbrisiSmer izbrisi = new IzbrisiSmer();
            izbrisi.ShowDialog();
        }

      

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            DodajStudenta dodaj = new DodajStudenta();
            dodaj.ShowDialog();
        }

        private void btnIzbrisiStudenta_Click_1(object sender, EventArgs e)
        {
            BrisanjeStudenta brisi = new BrisanjeStudenta();
            brisi.ShowDialog();
        }

        private void btnAzurirajStudenta_Click(object sender, EventArgs e)
        {
            AzuriranjeStudenta azuriraj = new AzuriranjeStudenta();
            azuriraj.ShowDialog();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            DodavanjePredmeta dodaj = new DodavanjePredmeta();
            dodaj.ShowDialog();
        }

        private void btnAzurirajPredmet_Click(object sender, EventArgs e)
        {
            AzuriranjePredmeta azuriranje = new AzuriranjePredmeta();
            azuriranje.ShowDialog();
        }

        private void btnIzbrisiPredmet_Click(object sender, EventArgs e)
        {
            BrisanjePredmeta brisanje= new BrisanjePredmeta();
            brisanje.ShowDialog();
        }

        private void btnDodajIzbornuListu_Click(object sender, EventArgs e)
        {
            DodajIzbornuListu dodaj = new DodajIzbornuListu();
            dodaj.ShowDialog();
        }

        private void btnAzuriranjeIzbornihLista_Click(object sender, EventArgs e)
        {
            AzuriranjeIzbornihLista azuriranje = new AzuriranjeIzbornihLista();
            azuriranje.ShowDialog();
        }

        private void btnObrisiIzbornuListu_Click(object sender, EventArgs e)
        {
            BrisanjeIzborneListe brisanje = new BrisanjeIzborneListe();
            brisanje.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
           
            log.Show();
            this.Dispose();
        }

        private void MeniAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Close();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            Statistika_predmeta statistika = new Statistika_predmeta();
            statistika.Show();
        }
    }
}
