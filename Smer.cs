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
    public class Smer
    {

        private static int id=1;
        private  int id_smera;
        private string ime_smera;

        public string Ime_smera
        {
            get
            {
                return ime_smera;
            }

            set
            {
                ime_smera = value;
            }
        }

        public Smer(string ime,int id)
        {

            ime_smera = ime;
            id_smera = id;


        }

        public Smer(string ime)
        {
            
            ime_smera = ime;
            id_smera = id++;
           

        }

        

        public static List<Smer> sviSmerovi()
        {
           
            List<Smer> smerovi=new List<Smer>();
            
            if(File.Exists("Smer.bin"))
            { 
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead("Smer.bin");
                smerovi= ((List<Smer>) bf.Deserialize(fs));                
                fs.Dispose();
                
            }
            
            
            return smerovi;
        }

        public static bool dodajSmer(string ime)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;

            if (File.Exists("Smer.bin"))
            {
                List<Smer> smerovi = Smer.sviSmerovi();

                foreach (Smer s in smerovi)
                {
                    if (s.ime_smera.Equals(ime.ToUpper()))
                    {
                        return false;
                    }
                }

                smerovi.Add(new Smer(ime));
                

                fs = File.OpenWrite("Smer.bin");
                bf.Serialize(fs, smerovi);
                fs.Dispose();
            }
            else
            {
                fs = File.OpenWrite("Smer.bin");
                bf.Serialize(fs, new Smer(ime));
                fs.Dispose();
            }
            return true;
        }


        public static void azurirajBrisanjeSmer(List<Smer> smerovi)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenWrite("Smer.bin");
            bf.Serialize(fs, smerovi);
            fs.Dispose();

        }

        

        public override string ToString()
        {
            return  ime_smera;
        }

       


    }
}
