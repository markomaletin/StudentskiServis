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
    public class Administratori
    {
        private string korisnicko_ime;
        private string password;

       

        public Administratori(string korIme, string pass)
        {
            this.korisnicko_ime = korIme;
            this.password = pass;
        }

        public static List<Administratori> sviAdministratori ()
        {
            List<Administratori> administratori = new List<Administratori>();

            if (File.Exists("Administratori.bin"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("Administratori.bin");
                administratori=((List<Administratori>)bf.Deserialize(fs));
                fs.Close();
            }

            return administratori;
        }

        public static bool dodajAdministratora(Administratori admin)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;

            if (File.Exists("Administratori.bin"))
            {
                List<Administratori> administratori = Administratori.sviAdministratori();

                foreach (Administratori a in administratori)
                {
                    if (a.ToString().Equals(admin.ToString()))
                    {
                        return false;

                    }
                }

                administratori.Add(admin);
                
                fs = File.OpenWrite("Administratori.bin");
                bf.Serialize(fs, administratori);
                fs.Close();
            }
            else
            {
                fs = File.OpenWrite("Administratori.bin");
                bf.Serialize(fs, admin);
                fs.Close();
            }
            return true;

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
            return korisnicko_ime+" "+password;
        }

    }
}
