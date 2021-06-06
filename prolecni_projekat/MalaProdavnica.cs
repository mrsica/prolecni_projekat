using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MalaProdavnica : Prodavnica
    {
        public MalaProdavnica(double povrsina) : base(povrsina)
        {
            if (povrsina > 70)
                throw new Exception("Mala prodavnica ima povrsinu manju od 70 m^2.");
            this.povrsina = povrsina;

            // ne znam bas sta cemo sa ovim? vrv treba izbaciti
            ponuda = new List<VrstaArtikla> { VrstaArtikla.Trajni, VrstaArtikla.MlecniProizvod, VrstaArtikla.VocePovrce, VrstaArtikla.Zaledjeno };

            spisak_slobodnih_radnih_mesta = new Dictionary<Uloga, int>() // prvo su sva mesta slobodna
            {
                {Uloga.Menadzer_Prodavnice, 2 }, {Uloga.Kasir, 2}, {Uloga.Aranzer,2}
            };

            // dodati spisak radnika (jel ovo dovoljno?)
            spisak_zaposlenih = new List<Radnik>();

            

            br_kasa = 1;
        }
    }
}
