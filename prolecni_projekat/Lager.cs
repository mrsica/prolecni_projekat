using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class Lager
    {
        MapaArtikala stanje;
        List<Artikal> skup_artikala;

        public int BrojArtikalaNaLageru
        {
            get { return skup_artikala.Count; }
        }

        //treba dodati bukv skup artikala koji postoje ovde
        public Lager()
        {
            //inicijalizuejem samo listu artikala (i ovo sto sam vec uradila)
            stanje = new MapaArtikala();
            skup_artikala = new List<Artikal>();
        }

        // TO_DO: dodati da se artikli mogu dodavati grupno

        public void Dodaj(Artikal a, int kolicina) 
        {
            stanje.Dodaj(a.BarKod, kolicina);
            skup_artikala.Add(a);
        }

        



        //public void IsporukaJednog(Artikal a, int kolicina)
        //{
        //    if(lager.ContainsKey(a))
        //    {
        //        lager[a] += kolicina;
        //    }
        //    else
        //    {
        //        lager.Add(a, kolicina);
        //    }
        //}

        //public void OcistiLager()
        //{
        //    foreach (var v in lager.Keys)
        //    {
        //        if (lager[v] == 0)
        //            lager.Remove(v);
        //    }
        //}

        //public void IsporukaVise()
        //public IEnumerator GetEnumerator()
        //{
        //    return lager.GetEnumerator();
        //}
    }
}
