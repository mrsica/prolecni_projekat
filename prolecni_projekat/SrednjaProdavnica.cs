using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class SrednjaProdavnica : Prodavnica
    {
        public SrednjaProdavnica(double povrsina) : base(povrsina)
        {
            if (povrsina > 200 && povrsina < 70)
                throw new Exception("Srednja prodavnica ima povrsinu izmedju 70 i 200 m^2.");
            this.povrsina = povrsina;

            // u ponudi nema samo peciva i kuvana jela
            // ne znam bas sta cemo sa ovim? vrv treba izbaciti
            ponuda = new List<VrstaArtikla> { VrstaArtikla.Trajni, VrstaArtikla.MlecniProizvod, VrstaArtikla.Meso, VrstaArtikla.SuvoMeso, VrstaArtikla.VocePovrce, VrstaArtikla.Zaledjeno };

            spisak_slobodnih_radnih_mesta = new Dictionary<Uloga, int>() // prvo su sva mesta slobodna
            {
                {Uloga.Menadzer_Prodavnice, 2 }, {Uloga.Kasir, 4}, {Uloga.Aranzer, 4}, {Uloga.Mesar, 4}, {Uloga.Pekar_Kuvar, 2}, {Uloga.PomocnoOsoblje, 2}
            };// u zad pise nema peciva, a trazi se 2 pekara? (stavila sam ih ovde za svaki sluc)

            spisak_zaposlenih = new List<Radnik>();

            br_kasa = 2;
        }
    }
}
