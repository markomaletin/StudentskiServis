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
    public partial class DodajIzbornuListu : Form
    {
        List<IzbornaLista> lista;
        List<Predmet> predmeti;
        CheckedListBox svi_predmeti_studenta;
        int broj;


        public DodajIzbornuListu()
        {
            InitializeComponent();
            broj = 0;
            lista = IzbornaLista.listeSvihStudenata();
            predmeti= Predmet.sviPredmeti();


            svi_predmeti_studenta = new CheckedListBox();
            svi_predmeti_studenta.ItemCheck += Svi_predmeti_studenta_ItemCheck;
           
          
           

        }

        private void Svi_predmeti_studenta_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox predmet = (CheckedListBox)sender;

            
            // racuna trenutni broj ESPB bodova
            for (int i= 0; i < svi_predmeti_studenta.Items.Count; i++ )
            {
                if(svi_predmeti_studenta.Items[i].Equals(predmet.SelectedItem))
                {
                    if (predmet.GetItemChecked(i) != true)
                        broj += 6;
                    else
                        broj -=6;
                    lblESPB.Text = "ESPB: " + broj;
                }
                
            }

            lblPoruka.ResetText();
        }

        private void DodajIzbornuListu_Load(object sender, EventArgs e)
        {
            List<Studenti> studenti = Studenti.sviStudenti();

            // dodavanje samo studenata koji nemaju izbornu listu
            foreach (Studenti s in studenti)
            {
               
                if(IzbornaLista.izbornaListaOdStudenta(s)==null)
                {
                    cmbStudenti.Items.Add(s);
                }
  
            }
            btnDodaj.Enabled = false;
           

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


     
        

        private void cmbStudenti_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            broj = 0;
            lblPoruka.Text = "";
            cmbStudenti.ResetText();
            svi_predmeti_studenta.Items.Clear();

            //checklistbox kreiranje
            svi_predmeti_studenta.Size = new Size(400, 200);
            svi_predmeti_studenta.Location = new Point(50, 150);
            Controls.Add(svi_predmeti_studenta);
           

            Studenti student = (Studenti)cmbStudenti.SelectedItem;
            
            
               //dodavanje predmeta u checklistbox ako su sa smera ili u chombobox ako nisu sa istog smera
                foreach (Predmet p in predmeti)
                {
                    if (p.Smer.ToString().Equals(student.Smer.ToString()))
                    {

                        string unos= p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar;
                        svi_predmeti_studenta.Items.Add(unos, (p.Obavezan) ?CheckState.Checked:CheckState.Unchecked);

                        if(p.Obavezan)
                        {
                            svi_predmeti_studenta.SetItemCheckState(svi_predmeti_studenta.Items.Count - 1, CheckState.Indeterminate);
                           
                        }
                    }
                    else
                    {
                        cmbPredmeti.Items.Insert(cmbPredmeti.Items.Count, p);
                    }
                    
                }
               

                btnDodaj.Enabled = true;

            //Trenutni ESPB bodovi
            broj = 0;
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    broj += 6;
                }

            }
            lblESPB.Text = "ESPB: " + broj;

        }

      

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Studenti student = (Studenti)cmbStudenti.SelectedItem;

            //Brisanje predmeta sa drugog smera da bi ubacio drugi
            for (int i= 0; i< svi_predmeti_studenta.Items.Count;i++)
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
            Predmet predmet =(Predmet) cmbPredmeti.SelectedItem;
            svi_predmeti_studenta.Items.Add(predmet.Naziv_predmeta + ",  " + predmet.Smer + ",  " + predmet.Semestar, true );
            svi_predmeti_studenta.SetSelected(svi_predmeti_studenta.Items.Count-1,true);
            cmbPredmeti.Items.Remove(predmet);

            //Trenutni ESPB bodovi
            broj = 0;
            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    broj += 6;
                }

            }
            lblESPB.Text = "ESPB: " + broj;

        }



        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            List<Predmet> predmeti = new List<Predmet>();
            lblPoruka.Text ="";

            //ubacuje u listu sve cekiranje predmete
            for (int i=0;i<svi_predmeti_studenta.Items.Count;i++)
            {
                
                if (svi_predmeti_studenta.GetItemCheckState(i)==CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    Predmet predmet = Predmet.vretiPredmetPoNazivu(svi_predmeti_studenta.Items[i].ToString());
                    if(predmet!=null)
                    predmeti.Add(predmet);
                    
                }
            }


            if(broj>=48)
            {
                IzbornaLista novaIzbornaLista = new IzbornaLista((Studenti)cmbStudenti.SelectedItem, predmeti);

                if (IzbornaLista.dodajIzbornuListu(novaIzbornaLista))
                {
                    lblPoruka.Text = "Uspešno ste dodali izbornu listu";
                    lblPoruka.ForeColor = Color.Blue;
                    svi_predmeti_studenta.Items.Clear();
                    cmbStudenti.Items.RemoveAt(cmbStudenti.SelectedIndex);
                    btnDodaj.Enabled = false;
                    cmbPredmeti.Items.Clear();
                }
                else
                {
                    lblPoruka.Text = "Došlo je do greške prilikom predaje izborne liste!";
                    lblPoruka.ForeColor = Color.Red;
                }
                

            }
            else
            {
                lblPoruka.Text = "Greška, nemate dovoljno ESPB bodova. Potrebno je imati najmanje 48, a trenutno imate "+broj+"!";
                lblPoruka.ForeColor = Color.Red;
            }
            
        }
    }
}
