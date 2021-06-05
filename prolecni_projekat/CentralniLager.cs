using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class CentralniLager : Lager
    {
        MapaArtikala lager_pokvareno;
        public CentralniLager()
        {
            lager_pokvareno = new MapaArtikala();
        }
    }
}
