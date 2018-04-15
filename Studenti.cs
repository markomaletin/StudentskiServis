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
    public class Studenti
    {
        private string index;
        private string ime_studenta;
        private string prezime_studenta;
        private string JMBG;
        private DateTime datum_rodjenja;
        private string telefon;
        private Smer smer;
        private string korisnicko_ime;
        private string password;

       // private Studenti studenti;

        public Studenti(string index, string ime_studenta, string prezime_studenta, string JMBG, DateTime datum_rodjenja, string telefon, Smer smer, string korime, string password)
        {
            this.Ime_studenta = ime_studenta;
            this.Index = index;
            this.Prezime_studenta = prezime_studenta;
            this.JMBG1 = JMBG;
            this.Datum_rodjenja = datum_rodjenja;
            this.Telefon = telefon;
            this.Smer = smer;
            this.korisnicko_ime = korime;
            this.password = password;

        }

        public Studenti(Studenti studenti)
        {
            this.Ime_studenta = studenti.ime_studenta;
            this.Index = studenti.index;
            this.Prezime_studenta = studenti.prezime_studenta;
            this.JMBG1 = studenti.JMBG;
            this.Datum_rodjenja = studenti.datum_rodjenja;
            this.Telefon = studenti.telefon;
            this.Smer = studenti.smer;
            this.korisnicko_ime = studenti.korisnicko_ime;
            this.password = studenti.password;
        }

        public static List<Studenti> sviStudenti()
        {
           List<Studenti> studenti = null;

            if (File.Exists("Student.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("Student.bin",FileMode.Open,FileAccess.Read);
                studenti=((List<Studenti>)bf.Deserialize(fs));
                fs.Close();

            }
            
            return studenti;
        }

        public static bool dodajStudenta(Studenti student)
        {
            
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;

            if (File.Exists("Student.bin"))
            {
                List<Studenti> studenti = Studenti.sviStudenti();

                foreach (Studenti s in studenti)
                {
                    if (s.ToString().Equals(student.ToString()))
                    {
                        return false;
                    }
                }

                studenti.Add(student);


                fs = File.OpenWrite("Student.bin");
                bf.Serialize(fs, studenti);
                fs.Close();
            }
            else
            {
                fs = File.OpenWrite("Student.bin");
                bf.Serialize(fs, student);
                fs.Close();
            }
            return true;
        }
    

        public static void azurirajBrisanjeStudenta(List<Studenti> studenti)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("Student.bin");
            bf.Serialize(fs, studenti);
            fs.Close();
        }

        public Smer Smer
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

        public string Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public string Ime_studenta
        {
            get
            {
                return ime_studenta;
            }

            set
            {
                ime_studenta = value;
            }
        }

        public string Prezime_studenta
        {
            get
            {
                return prezime_studenta;
            }

            set
            {
                prezime_studenta = value;
            }
        }

        public string JMBG1
        {
            get
            {
                return JMBG;
            }

            set
            {
                JMBG = value;
            }
        }

        public DateTime Datum_rodjenja
        {
            get
            {
                return datum_rodjenja;
            }

            set
            {
                datum_rodjenja = value;
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public string Korisnicko_ime
        {
            get
            {
                return korisnicko_ime;
            }

            set
            {
                korisnicko_ime = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public override string ToString()
        {
            return index+" "+Ime_studenta + " " + Prezime_studenta + " "+JMBG+ " " + Datum_rodjenja.ToShortDateString() + " " +telefon + " " + Smer + " " + korisnicko_ime;
        }
    }
}
