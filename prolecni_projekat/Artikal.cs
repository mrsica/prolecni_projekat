using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    //  nisam jos sig da li ovo da brisem
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

    enum StanjeArtikla
    {
        Normalno,
        PredIstekom,
        IstekoRok
    }
    abstract class Artikal
    {
        protected int bar_kod;
        protected string proizvodjac;
        protected string naziv;
        protected double cena;
        protected string ambalaza;
        protected DateTime rokTrajanja;//diskusija, da li treba uopste ovo, aranzer proverava, pravi nam razliku izmedju dva ista artikla
        protected string jedinicaProdaje;
        protected string usloviCuvanja; //opis
        protected VrstaArtikla vrsta;
        protected StanjeArtikla stanje;

        protected bool pred_istekom_roka;//nada dodala

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
            pred_istekom_roka = false;

            this.stanje = StanjeArtikla.Normalno;
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
            pred_istekom_roka = false;

            this.stanje = StanjeArtikla.Normalno;
        }

        public virtual void SmanjiCenu()
        {
            //TimeSpan razlika = rokTrajanja.Subtract(DateTime.Now);
            //if (razlika.TotalDays < 10)
            //{
                cena -= (cena / 10) * 3;

                //if(vrsta.Equals(VrstaArtikla.Meso) || vrsta.Equals(VrstaArtikla.MlecniProizvod) 
                //    || vrsta.Equals(VrstaArtikla.Pecivo_Kuvano))
                //{
                //    cena -= cena/2;
                //}
                //else
                //{
                //    cena -= (cena / 10) * 3;
                //}
            //}
        }

        /*public bool PredIstekom()
        {
            TimeSpan razlika = rokTrajanja.Subtract(DateTime.Now);
            if (razlika.TotalDays < 10)
                return true;
            return false;
        }

        public bool IstekoRok()
        {
            if (DateTime.Now > rokTrajanja)
                return true;
            return false;
        }*/


        //ovo izgleda ipak ne treba jer aranzer to treba da uradi i da vrati a ne kod???
        public StanjeArtikla NadjiStanje()
        {
            TimeSpan razlika = rokTrajanja.Subtract(DateTime.Now);
            if (razlika.TotalDays <= 0)
                return StanjeArtikla.IstekoRok;
            else if (razlika.TotalDays < 10)
                return StanjeArtikla.PredIstekom;
            else
                return StanjeArtikla.Normalno;
        }


        //public override bool Equals(object obj) // da li nam ovo treba?
        //{
        //    return obj is Artikal artikal && bar_kod == artikal.bar_kod &&
        //           proizvodjac == artikal.proizvodjac &&
        //           naziv == artikal.naziv &&
        //           cena == artikal.cena &&
        //           ambalaza == artikal.ambalaza &&
        //           rokTrajanja == artikal.rokTrajanja &&
        //           jedinicaProdaje == artikal.jedinicaProdaje &&
        //           usloviCuvanja == artikal.usloviCuvanja &&
        //           vrsta == artikal.vrsta;
        //}

        //public override int GetHashCode() // da li treba nesto dodati zbog bar_kod (da li nam treba ovo uopste?)
        //{
        //    int hashCode = 1466740483;
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(proizvodjac);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(naziv);
        //    hashCode = hashCode * -1521134295 + cena.GetHashCode();
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ambalaza);
        //    hashCode = hashCode * -1521134295 + rokTrajanja.GetHashCode();
        //    return hashCode;
        //}

    }
}
