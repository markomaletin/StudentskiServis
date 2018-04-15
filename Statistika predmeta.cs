using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat1
{
    public partial class Statistika_predmeta : Form
    {
        float pocetak = 0F;
        float kraj = 0F;
        Random slucajni;
        Rectangle r;

        public Statistika_predmeta()
        {
            InitializeComponent();
            slucajni = new Random();
            r = new Rectangle(50, 100, 200, 200);
            this.Height = 400;
        }

        private void Statistika_predmeta_Load(object sender, EventArgs e)
        {
            List<Smer> smerovi = Smer.sviSmerovi();
            foreach(Smer s in smerovi)
            {
                cmbSmerovi.Items.Add(s);
            }
        }

        int ukupan_broj = 0;
        int brojac = 0;

        List<Label> sve_labele = new List<Label>();

        private void cmbSmerovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.ResetText();

            Smer smer = (Smer)cmbSmerovi.SelectedItem;
            List<Predmet> predmeti = Predmet.predmetiSaSmera(smer);
            List<IzbornaLista> izborne_liste = IzbornaLista.listeSvihStudenata();

            ukupan_broj = 0;
            pocetak = 0;
            kraj = 0F;
            int y_pomeraj = 0;
            lblPoruka.Visible = false;


            Graphics g = this.CreateGraphics();

            this.Height = 400;

            //brisanje starih labela
            foreach (Label l in sve_labele)
            {
                 Controls.Remove(l);
            }
            sve_labele.Clear();
               
            // ukupan broj studenata na svim predmetima sa odabranog smera
            foreach (Predmet p in predmeti)
            {
                foreach (IzbornaLista lista in izborne_liste)
                {
                    if (lista.imaPredmetUListi(p))
                    {
                        ukupan_broj++;
                    }
                }
            }


            //ako nema studenta na predmetima sa smera
            if(ukupan_broj==0)
            {
                g.FillEllipse(Brushes.Silver, r);
                g.DrawEllipse(Pens.Black, r);

                lblPoruka.Visible = true;
            }

            

            foreach (Predmet p in predmeti)
            {
               
                //broj studenata
                brojac=0;

                foreach(IzbornaLista lista in izborne_liste)
                {
                    if(lista.imaPredmetUListi(p))
                    {
                        brojac++;
                    }
                }

                

                if (brojac>0)
                {
                   
                    pocetak += kraj;
                    kraj = (360 * brojac) / (float)ukupan_broj;

                    SolidBrush sb = new SolidBrush(Color.FromArgb(slucajni.Next(0, 256), slucajni.Next(0, 256), slucajni.Next(0, 256)));

                    g.DrawEllipse(Pens.Black, r);
                    g.FillPie(sb, r, pocetak, kraj);
                  
                    
                    //dodavanje labela sa predmetima
                    Label lbl = new Label();
                    sve_labele.Add(lbl);
                    lbl.Text += p.Naziv_predmeta + ",  Broj studenata:" + brojac +",  Procenat: "+ string.Format("{0:N1}%", (kraj*100)/360) + "\n";
                    lbl.BackColor = sb.Color;
                    lbl.ForeColor = Color.WhiteSmoke;
                    lbl.Font = new Font("Arial", 8, FontStyle.Bold);
                    lbl.Location = new Point(350, (50 + y_pomeraj));
                    lbl.Size = new Size(450, 20);
                    Controls.Add(lbl);
                    y_pomeraj += 35;

                }
                

               
            }

            //visina prozora
            if ((y_pomeraj + 100) > this.Height)
            {
                this.Height = y_pomeraj + 100;
            }
            else this.Height = 400;


            g.Dispose();
                
        }

        

        
       
    }
}
