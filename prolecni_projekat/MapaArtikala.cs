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
        Dictionary<int, int> mapa;  // key: bar_kod, value: kolicina 

        public MapaArtikala()
        {
            mapa = new Dictionary<int, int>();
        }

        public void Dodaj(int bk, int kolicina)
        {
            if (mapa.ContainsKey(bk))
            {
                mapa[bk] += kolicina;
            }
            else
            {
                mapa.Add(bk, kolicina);
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
