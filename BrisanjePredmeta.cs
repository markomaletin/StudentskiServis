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
    public partial class BrisanjePredmeta : Form
    {
        List<Predmet> predmeti = Predmet.sviPredmeti();

        public BrisanjePredmeta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void BrisanjePredmeta_Load(object sender, EventArgs e)
        {
            btnObrisi.Enabled = false;
            

            foreach(Predmet p in predmeti)
            {
                cmbPredmeti.Items.Add(p);
            }
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnObrisi.Enabled = true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            int broj = cmbPredmeti.SelectedIndex;
            Predmet predmet = (Predmet)cmbPredmeti.SelectedItem;


            List<IzbornaLista> izborne_liste = IzbornaLista.listeSvihStudenata();

            //brisanje predmeta iz izborne liste, ako ima manje od 48 ESPB brise celu listu
            for (int i = 0; i < izborne_liste.Count; i++)
            {
                    if (izborne_liste[i].imaPredmetUListi(predmet))
                    {
                        if ((izborne_liste[i].Predmeti_studenta.Count) * 6 - predmet.ESPB1 >= 48)
                        {
                            int index = izborne_liste[i].redniBrojPredmetaUListi(predmet);
                            izborne_liste[i].Predmeti_studenta.RemoveAt(index);
                        }
                        else
                        {
                            izborne_liste.RemoveAt(i);
                        }

                    }
                
            }
            IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborne_liste);

           // brisanje predmeta
            predmeti.RemoveAt(broj);
            cmbPredmeti.Items.RemoveAt(broj);
            Predmet.azuriranjeBrisanjePredmeta(predmeti);
            lblPoruka.Text = "Uspesno ste izbrisali predmet.";
            lblPoruka.ForeColor = Color.Blue;

            btnObrisi.Enabled = false;
        }
    }
}
