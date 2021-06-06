using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class CentralniLager : Lager
    {
        Lager lager_pokvareno;
        Lager lager_ispravno;
        public CentralniLager()
        {
            lager_ispravno = new Lager();
            lager_pokvareno = new Lager();
        }


    }
}
