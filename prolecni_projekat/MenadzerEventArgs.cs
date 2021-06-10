using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class MenadzerEventArgs:EventArgs
    {
        public MapaArtikala ma;

        public MenadzerEventArgs(MapaArtikala ma)
        {
            this.ma = ma;
        }
    }
}
