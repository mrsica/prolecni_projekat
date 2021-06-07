using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class Aranzer : Radnik
    {
        public Aranzer() : base(Uloga.Aranzer) { }

        public delegate void AranzerDelegateType(object sender, AranzerEventArgs args);

        public event AranzerDelegateType PokvarenoEvent;
        public event AranzerDelegateType PredIstekEvent;

        public override void radi()
        {
            throw new NotImplementedException();
        }

        public void Proveri(Lager lager, int odakle, int dokle)
        {
            PokvarenoEvent?.Invoke(this, new AranzerEventArgs(lager, odakle, dokle));
            //mozda ipak ovo treba da se poziva kada sazna da je pokvareno da se vrati na 
            //centralni lager
        }
    }
}
