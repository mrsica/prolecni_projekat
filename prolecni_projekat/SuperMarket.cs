using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class SuperMarket : VelikaProdavnica
    {
        public SuperMarket(double povrsina) : base(povrsina)
        {
            if (povrsina < 400)
                throw new Exception("Super market ima povrsinu vecu od 400 m^2.");
            this.povrsina = povrsina;
            // sve isto kao velika prodavnica, samo su cene uvek manje za 5%


        }
    }
}
