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
    public partial class BrisanjeStudenta : Form
    {
        public BrisanjeStudenta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<Studenti> studenti = Studenti.sviStudenti();
        private void BrisanjeStudenta_Load(object sender, EventArgs e)
        {
            btnObrisi.Enabled = false;

            foreach(Studenti s in studenti)
            {
                cmbStudenti.Items.Add(s);
            }
            
        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnObrisi.Enabled = true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int broj = cmbStudenti.SelectedIndex;
            Studenti student = (Studenti)cmbStudenti.SelectedItem;

            List<IzbornaLista> izborne_liste = IzbornaLista.listeSvihStudenata();
            for (int i = 0; i < izborne_liste.Count; i++)
            {
                if (izborne_liste[i].Student.ToString().Equals(student.ToString()))
                {
                    izborne_liste.RemoveAt(i);
                    break;
                }
            }
            
            IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborne_liste);

            
            studenti.Remove(student);
            cmbStudenti.Items.Remove(student);
            Studenti.azurirajBrisanjeStudenta(studenti);
            lblPoruka.Text = "Uspesno ste izbrisali studenta.";
            lblPoruka.ForeColor = Color.Blue;
            btnObrisi.Enabled = false;
        }
    }
}
