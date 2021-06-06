using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class Racun
    {
        
        //MapaArtikala racun; // nisam sigurna da li je ovo potrebno, imamo sad List<Artikala>
        DateTime datum;
        int br_kase;
        Kasir kasir;
        double iznos;
        List<Artikal> kupljeni_artikli;

        public double Iznos
        {
            get { return iznos; }
        }

        public Racun(DateTime datum, int br_kase, Kasir kasir)
        {
            this.datum = datum;
            this.br_kase = br_kase;
            this.kasir = kasir;
            //racun = new MapaArtikala();
            kupljeni_artikli = new List<Artikal>();
            iznos = 0;
        }

        //public void Dodaj(Artikal a, int kolicina) //jel ok?
        //{
        //    racun.Dodaj(a.BarKod, kolicina);
        //    iznos += a.Cena * kolicina;
        //}

        public void Dodaj(Artikal a)
        {
            //racun.Dodaj(a.BarKod, 1);
            kupljeni_artikli.Add(a);
            iznos += a.Cena;
        }

    }
}
