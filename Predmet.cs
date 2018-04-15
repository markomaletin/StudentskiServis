using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat1
{
    [Serializable()]
    class Predmet
    {
        private static int id=1;
        private int sifra;
        private string naziv_predmeta;
        private Smer smer;
        private string profesor;
        private int ESPB;
        private bool obavezan;
        private int semestar;

        

        public Predmet(string naziv_predmeta, Smer smer, string profesor, int espb, bool obavezan, int semestar)
        {
            sifra = id++;
            this.Naziv_predmeta = naziv_predmeta;
            this.Smer = smer;
            this.Profesor = profesor;
            this.ESPB1 = espb;
            this.Obavezan = obavezan;
            this.Semestar = semestar;
        }


        public Predmet(Predmet predmet)
        {
            this.sifra = predmet.sifra;
            this.Naziv_predmeta = predmet.Naziv_predmeta;
            this.Smer = predmet.Smer;
            this.Profesor = predmet.Profesor;
            this.ESPB1 = predmet.ESPB1;
            this.Obavezan = predmet.Obavezan;
            this.Semestar = predmet.Semestar;
        }


        public static List<Predmet> sviPredmeti()
        {
            List<Predmet> predmeti = null;

            if (File.Exists("Predmet.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("Predmet.bin");
                predmeti=((List<Predmet>) bf.Deserialize(fs));
                fs.Close();

            }

            return predmeti;
        }

        public static bool dodajPredmet(Predmet predmet)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;

            if (File.Exists("Predmet.bin"))
            {
                List<Predmet> predmeti = Predmet.sviPredmeti();

                foreach (Predmet p in predmeti)
                {
                    if (p.ToString().Equals(predmet.ToString()))
                    {
                        return false;
                    }
                }

                predmeti.Add(predmet);


                fs = File.OpenWrite("Predmet.bin");
                bf.Serialize(fs, predmeti);
                fs.Close();
            }
            else
            {
                fs = File.OpenWrite("Predmet.bin");
                bf.Serialize(fs, predmet);
                fs.Close();
            }
            return true;

        }

        public static void azuriranjeBrisanjePredmeta(List<Predmet> predmeti)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("Predmet.bin");
            bf.Serialize(fs, predmeti);
            fs.Close();
        }

        public static Predmet vretiPredmetPoNazivu(string nazivPredmeta)
        {
            string[] pom = nazivPredmeta.Split(',');

            string sve = "";

            for (int i= 0;i< pom.Length;i++)
            {
                pom[i] = pom[i].Trim();

                sve += pom[i] + " ";
            }
            

            List<Predmet> predmeti = Predmet.sviPredmeti();

            foreach(Predmet p in predmeti)
            {
                if(p.ToString().Contains(sve))
                {
                    return p;
                }
            }

            return null;
        }

        public static List<Predmet> predmetiSaSmera(Smer smer)
        {
            List<Predmet> saSmera = new List<Predmet>();
            List<Predmet> svi_predmeti = Predmet.sviPredmeti();

            if(smer!=null)
            foreach(Predmet p in svi_predmeti)
            {
                if(p.Smer.Ime_smera.Equals(smer.Ime_smera))
                {
                    saSmera.Add(p);
                }
            }

            return saSmera;
        }

        public string Naziv_predmeta
        {
            get
            {
                return naziv_predmeta;
            }

            set
            {
                naziv_predmeta = value;
            }
        }

        internal Smer Smer
        {
            get
            {
                return smer;
            }

            set
            {
                smer = value;
            }
        }

        public string Profesor
        {
            get
            {
                return profesor;
            }

            set
            {
                profesor = value;
            }
        }

        public int ESPB1
        {
            get
            {
                return ESPB;
            }

            set
            {
                ESPB = value;
            }
        }

        public bool Obavezan
        {
            get
            {
                return obavezan;
            }

            set
            {
                obavezan = value;
            }
        }

        public int Semestar
        {
            get
            {
                return semestar;
            }

            set
            {
                semestar = value;
            }
        }

        public override string ToString()
        {
            return  naziv_predmeta + " " + smer + " " + semestar + " " + profesor + " " + obavezan + " " + ESPB;
        }
    }
}
