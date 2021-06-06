using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class PecivoKuvano : Artikal
    {
        public PecivoKuvano(int bk, string pro, string n, double c, string amb, DateTime rok, string jp) :
            base(bk, pro, n, c, amb, rok, jp, VrstaArtikla.Pecivo_Kuvano)
        {
            bar_kod = bk;
            proizvodjac = pro;
            naziv = n;
            cena = c;
            ambalaza = amb;
            rokTrajanja = rok;
            jedinicaProdaje = jp;
        }

        public void SmanjiCenu()
        {
            TimeSpan razlika = rokTrajanja.Subtract(DateTime.Now);
            if (razlika.TotalDays < 10)
            {
                cena -= cena / 2;
            }

        }
    }
}
