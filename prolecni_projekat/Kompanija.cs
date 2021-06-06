using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class Kompanija
    {
        List<PoslovnaJedinica> poslovne_jedinice;
        GeneralniDirektor g_direktor;
        ZaposlenUDirekciji[] direkcija;

        public Kompanija()
        {
            poslovne_jedinice = new List<PoslovnaJedinica>();
            g_direktor = new GeneralniDirektor();
            direkcija = new ZaposlenUDirekciji[30];
        }

        public void PremestiPJ(PoslovnaJedinica pj, string grad)
        {
            pj.Grad = grad;
        }

        // moze da otvara i zatvara poslovne jedinice (event)
    }
}
