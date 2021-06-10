using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MenadzerProdavnice : Radnik
    {
        public MenadzerProdavnice() : base(Uloga.Menadzer_Prodavnice) { }

        public override void radi()
        {
            //primi robu
            //dogadjaj poziva se na lageru onPrijem robe
            throw new NotImplementedException();
        }

        public delegate void MenadzerDelegateType(object sender, MenadzerEventArgs args);

        public event MenadzerDelegateType PrimiRobuEvent;

        public void primiRobu(MapaArtikala ma)
        {
            PrimiRobuEvent?.Invoke(this,new MenadzerEventArgs(ma));
        }
    }
}
