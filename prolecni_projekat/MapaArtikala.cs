using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MapaArtikala
    {
        Dictionary<Artikal, int> mapa;

        public MapaArtikala()
        {
            mapa = new Dictionary<Artikal, int>();
        }

        public void Dodaj(Artikal a, int kolicina)
        {
            if (mapa.ContainsKey(a))
            {
                mapa[a] += kolicina;
            }
            else
            {
                mapa.Add(a, kolicina);
            }
        }

        public void UkloniPrazne()
        {
            foreach (var v in mapa.Keys)
            {
                if (mapa[v] == 0)
                    mapa.Remove(v);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return mapa.GetEnumerator();
        }
    }
}
