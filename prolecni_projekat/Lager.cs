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
        MapaArtikala lager;

        public Lager()
        {
            lager = new MapaArtikala();
        }

        public void Dodaj(Artikal a, int kolicina)
        {
            lager.Dodaj(a, kolicina);
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
