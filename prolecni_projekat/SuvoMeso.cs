using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class SuvoMeso : Artikal
    {
        public SuvoMeso(int bk, string pro, string n, double c, string amb, DateTime rok, string jp) :
            base(bk, pro, n, c, amb, rok, jp, VrstaArtikla.SuvoMeso)
        {
            bar_kod = bk;
            proizvodjac = pro;
            naziv = n;
            cena = c;
            ambalaza = amb;
            rokTrajanja = rok;
            jedinicaProdaje = jp;
        }
    }
}
