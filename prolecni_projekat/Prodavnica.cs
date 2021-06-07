using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    abstract class Prodavnica
    {
        
        protected Lager lager_prodavnice;
        protected int br_kasa;
        protected double povrsina;
        protected List<VrstaArtikla> ponuda;
        protected List<Radnik> spisak_zaposlenih;
        protected Dictionary<Uloga, int> spisak_slobodnih_radnih_mesta; // int - br slob mesta za odredjeni posao

        protected bool otvorena;
        protected int broj_zaposlenih_aranzera;

        public Prodavnica(double p)
        {
            lager_prodavnice = new Lager(); // ne znam gde ubacujem stvari u lager?
            povrsina = p;
            broj_zaposlenih_aranzera = 0;
        }

        protected bool ZaposliRadnika(Radnik r)
        {
            if (spisak_slobodnih_radnih_mesta.ContainsKey(r.UlogaRadnika) && spisak_slobodnih_radnih_mesta[r.UlogaRadnika] > 0)
            {
                spisak_zaposlenih.Add(r);
                spisak_slobodnih_radnih_mesta[r.UlogaRadnika]--;
                if (r.UlogaRadnika == Uloga.Aranzer)
                    broj_zaposlenih_aranzera++;
                return true;
            }
            return false;
        }

        protected bool OtpustiRadnika(Radnik r)
        {
            if(spisak_zaposlenih.Contains(r))
            {
                spisak_zaposlenih.Remove(r);
                spisak_slobodnih_radnih_mesta[r.UlogaRadnika]++;
                return true;
            }
            return false;
        }
        
        public void ZatvoriProdavnicu()
        {
            otvorena = false;
            // treba da trigeruje razne stvari (celokupan lager prodavnice se vraca nazad u centralni lager,
            // a zaposleni se upucuju u druge radnje 
        }


        //dogadjaj proveri

        public void ProveriArtikle()
        {
            int broj_artikala_po_aranzeru = lager_prodavnice.BrojArtikalaNaLageru / broj_zaposlenih_aranzera;
            int ind_aranzera = 0;
            foreach (Radnik r in spisak_zaposlenih)
            {
                if (r.UlogaRadnika == Uloga.Aranzer)
                {
                    Aranzer a = r as Aranzer;
                    //odakle dokle sa liste artikala sa lagera koje sve proverava 1 aranzer
                    a.Proveri(lager_prodavnice,ind_aranzera*broj_artikala_po_aranzeru,(ind_aranzera+1)*broj_artikala_po_aranzeru-1);
                    ind_aranzera++;
                }

                    
            }
            

        }

        
    }
}
