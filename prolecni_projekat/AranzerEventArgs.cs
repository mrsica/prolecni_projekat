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

        public AranzerEventArgs(Lager lager, int odakle, int dokle)
        {
            this.lager = lager;
            this.odakle = odakle;
            this.dokle = dokle;
        }
    }
}
