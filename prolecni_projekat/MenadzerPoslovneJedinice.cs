using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MenadzerPoslovneJedinice : Radnik
    {
        public MenadzerPoslovneJedinice() : base(Uloga.Menadzer_Posl_Jed) { }

        // valjda ovde ide samo lista prodavnica kojima upravlja (odnosno PJ kojom upravlja)

        public override void radi()
        {
            throw new NotImplementedException();
        }
    }
}
