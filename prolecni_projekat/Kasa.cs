using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class Kasa
    {
        List<Racun> otkucaniRacuni;
        Radnik kasir;
        // Racun trenutniRacun; da li nam treba ako ne pravimo GUI?
        int brojKase;
        double zarada;

        static int redniBroj = 0;

        public Kasa()
        {
            otkucaniRacuni = new List<Racun>();
            zarada = 0;
            brojKase = redniBroj;

            redniBroj++;
        }

        public void ZavrsiRacun(Racun racun)
        {
            otkucaniRacuni.Add(racun);
            zarada += racun.Iznos;
            //ovde valjda ide delegat da se maknu stvari sa lagera kad se zavrsi
            //moze da se napravi txt fajl da se cuvaju racuni
        }
    }
}
