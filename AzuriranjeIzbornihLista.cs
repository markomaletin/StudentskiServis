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
    public partial class AzuriranjeIzbornihLista : Form
    {

        IzbornaLista lista_studenta;
        CheckedListBox svi_predmeti_studenta;
        int broj_ESPB = 0;
        Studenti student;

        public AzuriranjeIzbornihLista()
        {
            InitializeComponent();
            svi_predmeti_studenta = new CheckedListBox();
            btnAzuriraj.Enabled = false;
            svi_predmeti_studenta.ItemCheck += Svi_predmeti_studenta_ItemCheck;
        }

        private void Svi_predmeti_studenta_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox predmet = (CheckedListBox)sender;

            // racuna trenutni broj ESPB bodova
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {
                if (svi_predmeti_studenta.Items[i].Equals(predmet.SelectedItem))
                {
                    if (svi_predmeti_studenta.GetItemCheckState(i) != CheckState.Checked)
                        broj_ESPB += 6;
                    else
                        broj_ESPB -= 6;
                    lblESPB.Text = "ESPB: " + broj_ESPB;
                }
            }

            lblPoruka.ResetText();
        }

        private void AzuriranjeIzbornihLista_Load(object sender, EventArgs e)
        {
            List<IzbornaLista> izborneListe = IzbornaLista.listeSvihStudenata();
            // dodavanje samo studenata koji imaju izbornu listu
            foreach (IzbornaLista i in izborneListe)
            {
                cmbStudenti.Items.Add(i.Student);
            }
        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            broj_ESPB = 0;
            lblPoruka.Text = "";
            student = (Studenti)cmbStudenti.SelectedItem;
            lista_studenta = IzbornaLista.izbornaListaOdStudenta(student);

            //checklistbox kreiranje
            svi_predmeti_studenta.Items.Clear();
            svi_predmeti_studenta.Size = new Size(400, 200);
            svi_predmeti_studenta.Location = new Point(50, 150);
            Controls.Add(svi_predmeti_studenta);

            //dodavanje predmeta u checklistbox iz izborne liste studenta
            foreach (Predmet p in lista_studenta.Predmeti_studenta)
            {
                string unos = p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar;

                svi_predmeti_studenta.Items.Add(unos, true);

                if (p.Obavezan)
                {
                    svi_predmeti_studenta.SetItemCheckState(svi_predmeti_studenta.Items.Count - 1, CheckState.Indeterminate);

                }
                
               
            }

            List<Predmet> svi_predmeti = Predmet.sviPredmeti();

            //dodavanje predmeta u checklistbox ako su sa smera ili u chombobox ako nisu sa istog smera
            foreach (Predmet p in svi_predmeti)
            {
                if(!lista_studenta.imaPredmetUListi(p))
                {
                   if(p.Smer.ToString().Equals(student.Smer.ToString()))
                    {
                        svi_predmeti_studenta.Items.Add(p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar);
                    }
                    else cmbPredmeti.Items.Add(p);
                }
            }
            btnAzuriraj.Enabled = true;

            //Trenutni ESPB bodovi
            broj_ESPB = 0;
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    broj_ESPB += 6;
                }

            }
            lblESPB.Text = "ESPB: " + broj_ESPB;

        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studenti student = (Studenti)cmbStudenti.SelectedItem;

            //Brisanje predmeta sa drugog smera da bi ubacio drugi
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {
                Predmet p = Predmet.vretiPredmetPoNazivu(svi_predmeti_studenta.Items[i].ToString());

                if(p!=null)

                if (!p.Smer.ToString().Equals(student.Smer.ToString()))
                {
                    svi_predmeti_studenta.Items.RemoveAt(i);
                    cmbPredmeti.Items.Add(p);
                }

            }

            //Ubacivanje novog predmeta
            Predmet predmet = (Predmet)cmbPredmeti.SelectedItem;
            svi_predmeti_studenta.Items.Add(predmet.Naziv_predmeta + ",  " + predmet.Smer + ",  " + predmet.Semestar, true);
            cmbPredmeti.Items.Remove(predmet);
            
            //Trenutni ESPB bodovi
            broj_ESPB = 0;
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    broj_ESPB += 6;
                }

            }
            lblESPB.Text = "ESPB: " + broj_ESPB;



        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

           
            int broj = cmbStudenti.SelectedIndex;

            List<Predmet> predmeti = new List<Predmet>();

            //ubacuje u listu sve cekiranje predmete
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    Predmet predmet = Predmet.vretiPredmetPoNazivu(svi_predmeti_studenta.Items[i].ToString());
                    if (predmet != null)
                    predmeti.Add(predmet);
                }
            }


            if(broj_ESPB>=48)
            {
                IzbornaLista nova_lista = new IzbornaLista(student, predmeti);

                if (lista_studenta.ToString().Equals(nova_lista.ToString()))
                {
                    lblPoruka.Text = "Greška, nije nista promenjeno!";
                    lblPoruka.ForeColor = Color.Red;
                }
                else
                {

                    List<IzbornaLista> izborneListeIzDatoteke = IzbornaLista.listeSvihStudenata();
                    izborneListeIzDatoteke.RemoveAt(broj);
                    
                    izborneListeIzDatoteke.Insert(broj, nova_lista);

                    IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborneListeIzDatoteke);

                    lblPoruka.Text = "Uspesno ste ažurirali izbornu listu!";
                    lblPoruka.ForeColor = Color.Blue;
                    cmbStudenti.ResetText();
                    svi_predmeti_studenta.Items.Clear();
                    btnAzuriraj.Enabled = false;
                    cmbPredmeti.Items.Clear();


                }
            }
            else
            {
                lblPoruka.Text = "Greška, nemate dovoljno ESPB bodova. Potrebno je imati najmanje 48, a trenutno imate " + broj_ESPB+"!";
                lblPoruka.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
