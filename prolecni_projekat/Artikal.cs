using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    enum VrstaArtikla
    {
        Trajni,
        MlecniProizvod,
        Meso,
        SuvoMeso,
        Pecivo_Kuvano,
        VocePovrce,
        Zaledjeno
    }
    class Artikal
    {
        string proizvodjac;
        string naziv;
        double cena;
        string ambalaza;
        DateTime rokTrajanja;
        string jedinicaProdaje;
        string usloviCuvanja;
        VrstaArtikla vrsta;
        

        

        public Artikal(string proizvodjac, string naziv, double cena, string ambalaza, DateTime rokTrajanja, string jedinicaProdaje, VrstaArtikla vrsta, string usloviCuvanja)
        {
            this.proizvodjac = proizvodjac;
            this.naziv = naziv;
            this.cena = cena;
            this.ambalaza = ambalaza;
            this.rokTrajanja = rokTrajanja;
            this.jedinicaProdaje = jedinicaProdaje;
            this.usloviCuvanja = usloviCuvanja;
            this.vrsta = vrsta;
        }

        //konstruktor kad nema uslova cuvanja
        public Artikal(string proizvodjac, string naziv, double cena, string ambalaza, DateTime rokTrajanja, string jedinicaProdaje, VrstaArtikla vrsta)
        {
            this.proizvodjac = proizvodjac;
            this.naziv = naziv;
            this.cena = cena;
            this.ambalaza = ambalaza;
            this.rokTrajanja = rokTrajanja;
            this.jedinicaProdaje = jedinicaProdaje;
            this.usloviCuvanja = "";
            this.vrsta = vrsta;
        }

        public void SmanjiCenu()
        {
            TimeSpan razlika = rokTrajanja.Subtract(DateTime.Now);
            if(razlika.TotalDays<10)
            {
                if(vrsta.Equals(VrstaArtikla.Meso) || vrsta.Equals(VrstaArtikla.MlecniProizvod) 
                    || vrsta.Equals(VrstaArtikla.Pecivo_Kuvano))
                {
                    cena -= cena/2;
                }
                else
                {
                    cena -= (cena / 10) * 3;
                }
            }
        }
    }
}
