using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    abstract class Prodavnica
    {
        // da li su by default protected polja?
        protected Lager lager_prodavnice;
        protected int br_kasa;
        protected double povrsina;
        protected List<VrstaArtikla> ponuda;
        protected List<Radnik> spisak_zaposlenih;
        protected Dictionary<Uloga, int> spisak_slobodnih_radnih_mesta; // int - br slob mesta za odredjeni posao

        protected bool ZaposliRadnika(Radnik r)
        {
            if (spisak_slobodnih_radnih_mesta.ContainsKey(r.UlogaRadnika) && spisak_slobodnih_radnih_mesta[r.UlogaRadnika] > 0)
            {
                spisak_zaposlenih.Add(r);
                spisak_slobodnih_radnih_mesta[r.UlogaRadnika]--;
                return true;
            }
            return false;
        }

        

        //public Prodavnica(Lager lager, int brojkasa, List<Uloga> radna_mesta)
        //{

        //}
    }
}
