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
        
        MapaArtikala racun;
        DateTime datum;
        int br_kase;
        Radnik kasir;
        double iznos;

        public double Iznos
        {
            get { return iznos; }
        }

        public Racun(DateTime datum, int br_kase, Radnik kasir)
        {
            this.datum = datum;
            this.br_kase = br_kase;
            this.kasir = kasir;
            racun = new MapaArtikala();
            iznos = 0;
        }

        public void Dodaj(Artikal a, int kolicina) //jel ok?
        {
            racun.Dodaj(a.BarKod, kolicina);
            iznos += a.Cena * kolicina;
        }

        public void Dodaj(Artikal a)
        {
            racun.Dodaj(a.BarKod, 1);
            iznos += a.Cena;
        }

    }
}
