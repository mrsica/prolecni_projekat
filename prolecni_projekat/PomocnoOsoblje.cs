using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class PomocnoOsoblje : Radnik
    {
        public PomocnoOsoblje() : base(Uloga.PomocnoOsoblje) { }

        public override void radi()
        {
            throw new NotImplementedException();
        }
    }
}
