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
    public partial class KorisnikMeni : Form
    {
        private Logovanje logovanje;
        private Studenti student; 
        private int broj_ESPB=0;
        List<Predmet> predmeti_za_sortiranje;


        //delegat za sortiranje liste predmeta
        private delegate void delSortiranje(List<Predmet> predmeti);

        public KorisnikMeni()
        {
            InitializeComponent();
        }


        public KorisnikMeni(Logovanje log, Studenti s): this()
        {
            
            this.logovanje = log;
            this.student = s;
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

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

            svi_predmeti_studenta.Items.Clear();

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
            cmbPredmeti.Items.Remove(predmet);

            

            predmeti_za_sortiranje.Add(predmet);

            //kreiranje delegata i dodavanje funkcija
            delSortiranje deleg = new delSortiranje(sortirajPoSemestru);
            deleg += new delSortiranje(sortirajPoImenu);
            deleg += new delSortiranje(prikazSortiraneListe);

            //pozivanje delegata
            deleg(predmeti_za_sortiranje);

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

        


        private void KorisnikMeni_Load(object sender, EventArgs e)
        {
            lblPodaciStudenta.Text = "Ime studenta: " + student.Ime_studenta + "\nPrezime: " + student.Prezime_studenta + "\nSmer: " + student.Smer.ToString();
            lblPodaciStudenta.ForeColor = Color.Blue;

            IzbornaLista lista_studenta = IzbornaLista.izbornaListaOdStudenta(student);
            List<Predmet> svi_predmeti = Predmet.sviPredmeti();

            predmeti_za_sortiranje = new List<Predmet>();

            if (lista_studenta != null)
            {
                //ako student ima izbornu listu
                //dodaje u checklistbox sve predmete iz izborne liste studenta
                foreach (Predmet p in lista_studenta.Predmeti_studenta)
                {
                    predmeti_za_sortiranje.Add(p);

                }


                //dodaje u checklistbox predmete sa smera ili u combobox predmete sa drugog smera
                foreach (Predmet p in svi_predmeti)
                {
                    if (!lista_studenta.imaPredmetUListi(p))
                    {
                        if (p.Smer.ToString().Equals(student.Smer.ToString()))
                        {
                            predmeti_za_sortiranje.Add(p);
                           
                        }
                        else cmbPredmeti.Items.Add(p);
                    }
                }
            }
            else
            {
                //ako student nema izbornu listu
                //ubacuje predmete sa smera u checklistbox, a ostale u combobox
                foreach (Predmet p in svi_predmeti)
                {
                    if (p.Smer.ToString().Equals(student.Smer.ToString()))
                    {
                        predmeti_za_sortiranje.Add(p);
                        
                    }
                    else
                    {
                        cmbPredmeti.Items.Insert(cmbPredmeti.Items.Count, p);
                    }

                }
            }

            //kreiranje delegata i dodavanje funkcija
            delSortiranje deleg = new delSortiranje(sortirajPoSemestru);
            deleg += new delSortiranje(sortirajPoImenu);
            deleg += new delSortiranje(prikazSortiraneListe);

            //pozivanje delegata
            deleg(predmeti_za_sortiranje);

        }




        private void brnOdjava_Click(object sender, EventArgs e)
        {
            logovanje.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            logovanje.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            List<IzbornaLista> izborneListeIzDatoteke = IzbornaLista.listeSvihStudenata();
            IzbornaLista lista_studenta = IzbornaLista.izbornaListaOdStudenta(student);

            int broj=0;

            //redni broj izborne liste
            for (int i=0; i<izborneListeIzDatoteke.Count; i++)
            {
                if(izborneListeIzDatoteke[i].ToString().Equals(lista_studenta.ToString()))
                {
                    broj = i;
                    break;
                }
            }

            //ubacuje u listu sve cekiranje predmete
            List<Predmet> predmeti = new List<Predmet>();

            for (int i = 0; i < svi_predmeti_studenta.Items.Count; i++)
            {

                if (svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Checked || svi_predmeti_studenta.GetItemCheckState(i) == CheckState.Indeterminate)
                {
                    Predmet predmet = Predmet.vretiPredmetPoNazivu(svi_predmeti_studenta.Items[i].ToString());
                    if (predmet != null)    predmeti.Add(predmet);
                }
            }


            if (broj_ESPB >= 48)
            {

                IzbornaLista nova_lista = new IzbornaLista(student, predmeti);

                if(lista_studenta==null)
                {
                    if (IzbornaLista.dodajIzbornuListu(nova_lista))
                    {
                        lblPoruka.Text = "Uspešno ste dodali izbornu listu";
                        lblPoruka.ForeColor = Color.Blue;
                        svi_predmeti_studenta.Items.Clear();
                        btnIzmeni.Enabled = false;
                        cmbPredmeti.Items.Clear();
                        logovanje.Show();
                        this.Close();
                        return;
                    }
                    else
                    {
                        lblPoruka.Text = "Došlo je do greške prilikom predaje izborne liste!";
                        lblPoruka.ForeColor = Color.Red;
                        logovanje.Show();
                        this.Close();
                        return;
                    }
                }

                if (lista_studenta.ToString().Equals(nova_lista.ToString()))
                {
                    lblPoruka.Text = "Greška, nije nista promenjeno!";
                    lblPoruka.ForeColor = Color.Red;
                }
                else
                {

                    
                    izborneListeIzDatoteke.RemoveAt(broj);

                    lista_studenta.Predmeti_studenta = predmeti;
                    izborneListeIzDatoteke.Insert(broj, lista_studenta);

                    IzbornaLista.azuriranjeBrisanjeIzbornihLista(izborneListeIzDatoteke);

                    lblPoruka.Text = "Uspešno ste ažurirali izbornu listu!";
                    lblPoruka.ForeColor = Color.Blue;

                    logovanje.Show();
                    this.Close();

                }
            }
            else
            {
                lblPoruka.Text = "Greška, nemate dovoljno ESPB bodova. Potrebno je imati najmanje 48, a trenutno imate " + broj_ESPB + "!";
                lblPoruka.ForeColor = Color.Red;
            }
        }


        private static void sortirajPoSemestru(List<Predmet> predmeti)
        {
            for(int i=0; i<predmeti.Count-1; i++ )
            {
                for (int j= i+1; j < predmeti.Count; j++)
                {
                    if (predmeti[i].Semestar > predmeti[j].Semestar)
                    {
                        Predmet pom = predmeti[i];
                        predmeti[i] = predmeti[j];
                        predmeti[j] = pom;
                    }
                }
            }
        }

        private static void sortirajPoImenu(List<Predmet> predmeti)
        {
           
           
            for (int i = 0; i < predmeti.Count - 1; i++)
            {
                for (int j = i + 1; j < predmeti.Count; j++)
                {
                    if ((String.Compare(predmeti[i].Naziv_predmeta, predmeti[j].Naziv_predmeta)==1) && (predmeti[i].Semestar == predmeti[j].Semestar))
                    {
                        Predmet pom = predmeti[i];
                        predmeti[i] = predmeti[j];
                        predmeti[j] = pom;
                    }
                }
               
            }
        }


        private  void prikazSortiraneListe(List<Predmet> predmeti_za_sortiranje)
        {
            IzbornaLista lista_studenta = IzbornaLista.izbornaListaOdStudenta(student);

            //dodavanje sortirane liste predmeta u checklistbox
            foreach (Predmet p in predmeti_za_sortiranje)
            {
                
                if (lista_studenta != null)
                {
                    if (lista_studenta.imaPredmetUListi(p))
                    {
                        svi_predmeti_studenta.Items.Add(p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar, (p.Obavezan) ? CheckState.Indeterminate : CheckState.Checked);

                    }
                    else
                    {
                        svi_predmeti_studenta.Items.Add(p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar, (p.Obavezan) ? CheckState.Indeterminate : CheckState.Unchecked);
                    }
                }
                else
                {
                    svi_predmeti_studenta.Items.Add(p.Naziv_predmeta + ",  " + p.Smer + ",  " + p.Semestar, (p.Obavezan) ? CheckState.Indeterminate : CheckState.Unchecked);

                }
            }


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


    }
}
