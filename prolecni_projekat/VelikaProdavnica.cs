using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class VelikaProdavnica : Prodavnica
    {
        public VelikaProdavnica(double povrsina)
        {
            if (povrsina > 400 && povrsina < 200)
                throw new Exception("Srednja prodavnica ima povrsinu izmedju 200 i 400 m^2.");
            this.povrsina = povrsina;
            // u ponudi ima sve vrste artikala
            ponuda = new List<VrstaArtikla> { VrstaArtikla.Trajni, VrstaArtikla.MlecniProizvod, VrstaArtikla.Meso, VrstaArtikla.SuvoMeso, VrstaArtikla.Pecivo_Kuvano, VrstaArtikla.VocePovrce, VrstaArtikla.Zaledjeno };

            int prosirenje = (int)((povrsina - 200) / 50);
            spisak_slobodnih_radnih_mesta = new Dictionary<Uloga, int>() // prvo su sva mesta slobodna
            {
                {Uloga.Menadzer, 2 + 2*prosirenje }, {Uloga.Kasir, 4 + 2*prosirenje}, {Uloga.Aranzer, 4 + 2*prosirenje}, {Uloga.Mesar, 4 + 2*prosirenje}, {Uloga.Pekar_Kuvar, 2 + 2*prosirenje}, {Uloga.PomocnoOsoblje, 2 + 2*prosirenje}
            };// u zad pise nema peciva, a trazi se 2 pekara? (stavila sam ih ovde za svaki sluc)

            spisak_zaposlenih = new List<Radnik>();

            br_kasa = 2 + prosirenje;
        }
    }
}
