using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class AranzerEventArgs:EventArgs
    {
        Lager lager;
        int odakle;
        int dokle;

        Artikal a;

        public AranzerEventArgs(Artikal a)
        {
            this.a = a;
        }

        //msm da ne treba, napravljeno u zbunj fazi xd
        public AranzerEventArgs(Lager lager, int odakle, int dokle)
        {
            this.lager = lager;
            this.odakle = odakle;
            this.dokle = dokle;
        }
    }
}
