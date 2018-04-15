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
    class IzbornaLista
    {
        private Studenti student;
        private List<Predmet> predmeti_studenta;

       

        public IzbornaLista(Studenti student, List<Predmet> predmet)
        {
            this.student = student;
            this.predmeti_studenta = predmet;
        }

        public static List<IzbornaLista> listeSvihStudenata()
        {

            List<IzbornaLista> liste = new List<IzbornaLista>();

            if (File.Exists("IzborneListe.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("IzborneListe.bin");
                liste.AddRange((List<IzbornaLista>) bf.Deserialize(fs));
                fs.Close();
            }


            return liste;
        }

        public static bool dodajIzbornuListu(IzbornaLista iLista)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;

            if (File.Exists("IzborneListe.bin"))
            {
                List<IzbornaLista> izborneListe = IzbornaLista.listeSvihStudenata();

                foreach (IzbornaLista p in izborneListe)
                {
                    if (p.Student.ToString().Equals(iLista.Student.ToString()))
                    {
                        return false;
                        
                    }
                }

                izborneListe.Add(iLista);


                fs = File.OpenWrite("IzborneListe.bin");
                bf.Serialize(fs, izborneListe);
                fs.Close();
            }
            else
            {
                fs = File.OpenWrite("IzborneListe.bin");
                bf.Serialize(fs, iLista);
                fs.Close();
            }
            return true;

        }

        public static void azuriranjeBrisanjeIzbornihLista(List<IzbornaLista> izborneListe)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("IzborneListe.bin");
            bf.Serialize(fs, izborneListe);
            fs.Close();
        }




        public static IzbornaLista izbornaListaOdStudenta(Studenti student)
        {
            List<IzbornaLista> liste = IzbornaLista.listeSvihStudenata();

            if(student!=null)
            foreach(IzbornaLista i in liste)
            {
                if(i.Student.ToString().Equals(student.ToString()))
                {
                    return i;
                }
            }

            return null;
           
        }


        public bool imaPredmetUListi(Predmet predmet)
        {
            foreach(Predmet p in this.predmeti_studenta)
            {
                if(predmet.ToString().Equals(p.ToString()))
                {
                    return true;
                }
            } 

            return false;
        }


        public int redniBrojPredmetaUListi(Predmet predmet)
        {
            
            for(int i=0; i<this.predmeti_studenta.Count;i++)
            {
                if (this.predmeti_studenta[i].ToString().Equals(predmet.ToString()))
                {
                    return i;
                }
            }

            return -1;
        }


        public Studenti Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        internal List<Predmet> Predmeti_studenta
        {
            get
            {
                return predmeti_studenta;
            }

            set
            {
                predmeti_studenta = value;
            }
        }

        public override string ToString()
        {
            string ispis = "";
            foreach(Predmet p in predmeti_studenta)
            {
                ispis += p + " ";
            }
            return student.Ime_studenta+" "+ ispis;
        }
    }
}
