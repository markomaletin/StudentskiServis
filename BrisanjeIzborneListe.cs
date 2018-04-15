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
    public partial class BrisanjeIzborneListe : Form
    {
        List<IzbornaLista> sve_izborne_liste;
        Studenti student;


        public BrisanjeIzborneListe()
        {
            InitializeComponent();
        }

        private void BrisanjeIzborneListe_Load(object sender, EventArgs e)
        {
            sve_izborne_liste = IzbornaLista.listeSvihStudenata();
            foreach(IzbornaLista i in sve_izborne_liste)
            {
                cmbStudenti.Items.Add(i.Student);
            }
            btnObrisi.Enabled = false;
        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPoruka.Text = "";
            student = (Studenti)cmbStudenti.SelectedItem;
            btnObrisi.Enabled = true;
            

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int broj = cmbStudenti.SelectedIndex;

            IzbornaLista izborna_lista = IzbornaLista.izbornaListaOdStudenta(student);
            sve_izborne_liste.RemoveAt(broj);

            IzbornaLista.azuriranjeBrisanjeIzbornihLista(sve_izborne_liste);

            lblPoruka.Text = "Uspešno ste izbrisali izbornu listu!";
            lblPoruka.ForeColor = Color.Blue;
            cmbStudenti.Items.RemoveAt(broj);
            btnObrisi.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
