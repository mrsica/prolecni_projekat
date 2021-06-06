using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    class PoslovnaJedinica
    {
        List<Prodavnica> prodavnice;
        string grad; 
        CentralniLager c_lager;
        List<Radnik> zaposleni;
        Dictionary<Uloga, int> spisak_slobodnih_radnih_mesta;
        //DirektorPoslovneJedinice direktor;

        //public DirektorPoslovneJedinice DirektorPJ
        //{
        //    get { return direktor; }
        //    set { direktor = value; }
        //}
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public PoslovnaJedinica(string g)
        {
            grad = g;
            prodavnice = new List<Prodavnica>();
            c_lager = new CentralniLager();
            zaposleni = new List<Radnik>();
            spisak_slobodnih_radnih_mesta = new Dictionary<Uloga, int>()
            {
                {Uloga.Direktor_Posl_Jed,2 }, {Uloga.Menadzer_Posl_Jed, 6}, {Uloga.PomocnoOsoblje, 30}
            };
            //direktor = new DirektorPoslovneJedinice();
        }
    }
}
