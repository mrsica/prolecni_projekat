using System;
using System.Collections;
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
        int bar_kod;
        string proizvodjac;
        string naziv;
        double cena;
        string ambalaza;
        DateTime rokTrajanja;
        string jedinicaProdaje;
        string usloviCuvanja; //opis
        VrstaArtikla vrsta;

        public double Cena
        {
            get { return cena; }
        }        
        
        public int BarKod
        {
            get { return bar_kod; }
        }

        public Artikal(int bar_kod, string proizvodjac, string naziv, double cena, string ambalaza, DateTime rokTrajanja, string jedinicaProdaje, VrstaArtikla vrsta, string usloviCuvanja)
        {
            this.bar_kod = bar_kod;
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
        public Artikal(int bar_kod, string proizvodjac, string naziv, double cena, string ambalaza, DateTime rokTrajanja, string jedinicaProdaje, VrstaArtikla vrsta)
        {
            this.bar_kod = bar_kod;
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
            if(razlika.TotalDays < 10)
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

        public bool IstekoRok()
        {
            if (DateTime.Now > rokTrajanja)
                return true;
            return false;
        }

        public override bool Equals(object obj) // da li nam ovo treba?
        {
            return obj is Artikal artikal && bar_kod == artikal.bar_kod &&
                   proizvodjac == artikal.proizvodjac &&
                   naziv == artikal.naziv &&
                   cena == artikal.cena &&
                   ambalaza == artikal.ambalaza &&
                   rokTrajanja == artikal.rokTrajanja &&
                   jedinicaProdaje == artikal.jedinicaProdaje &&
                   usloviCuvanja == artikal.usloviCuvanja &&
                   vrsta == artikal.vrsta;
        }

        public override int GetHashCode() // da li treba nesto dodati zbog bar_kod (da li nam treba ovo uopste?)
        {
            int hashCode = 1466740483;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(proizvodjac);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(naziv);
            hashCode = hashCode * -1521134295 + cena.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ambalaza);
            hashCode = hashCode * -1521134295 + rokTrajanja.GetHashCode();
            return hashCode;
        }

    }
}
