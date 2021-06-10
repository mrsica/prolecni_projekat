using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MapaArtikala:IDictionary<Artikal,int>
    {
        Dictionary<Artikal, int> mapa;  // key: sad je Artikal a bar_kod je u stvari hashcode, value: kolicina 

        public ICollection<Artikal> Keys => mapa.Keys;

        public ICollection<int> Values => mapa.Values;

        public int Count => mapa.Count;

        public bool IsReadOnly => false;
        
        //nije mi bas jasno cemu ovo
        public int this[Artikal key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Size()
        {
            return mapa.Count;
        }

        public MapaArtikala()
        {
            mapa = new Dictionary<Artikal, int>();
        }

        //moze da se zove azuriraj posto ima ovo sa += i da ima bool ako je true onda se dodaje, ako se skida kao kod
        //otkucavanja racuna ide false
        public void Dodaj(Artikal bk, int kolicina)
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

        public bool ContainsKey(Artikal key)
        {
            return mapa.ContainsKey(key);
        }

        public void Add(Artikal key, int value)
        {
            mapa.Add(key,value);
        }

        public bool Remove(Artikal key)
        {
            return mapa.Remove(key);
        }

        public bool TryGetValue(Artikal key, out int value)
        {
            return mapa.TryGetValue(key,out value);
        }

        public void Add(KeyValuePair<Artikal, int> item)
        {
            mapa.Add(item.Key,item.Value);
        }

        public void Clear()
        {
            mapa.Clear();
        }

        public bool Contains(KeyValuePair<Artikal, int> item)
        {
            return mapa.Contains(item);
        }

        public void CopyTo(KeyValuePair<Artikal, int>[] array, int arrayIndex)
        {
            //? nzm sta je ovo
        }

        public bool Remove(KeyValuePair<Artikal, int> item)
        {
            return mapa.Remove(item.Key);
        }

        IEnumerator<KeyValuePair<Artikal, int>> IEnumerable<KeyValuePair<Artikal, int>>.GetEnumerator()
        {
            return mapa.GetEnumerator();
        }
    }
}
