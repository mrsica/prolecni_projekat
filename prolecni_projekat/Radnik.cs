﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolecni_projekat
{
    enum Uloga
    {
        Kasir,
        Aranzer,
        Mesar,
        Pekar_Kuvar,
        Menadzer,
        Direktor,
        Direkcija,
        PomocnoOsoblje
    }

    //ovo mora da se resi kako cemo da uradimo
    class Radnik
    {
        string ime;
        string prezime;
        int godiste;
        int id;
        Uloga uloga;

        static int redniBr=0;

        public Radnik(string ime, string prezime, int godiste)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godiste = godiste;
            this.id = redniBr;
            //this.uloga = uloga;
            

            redniBr++;
        }
    }

    //class Mesar : Radnik
    //{
    //    string ime;
    //    string prezime;
    //    int godiste;
    //    int id;
    //    Uloga uloga;
    //    public Mesar(string ime, string prezime, int godiste):base(ime,prezime,godiste)
    //    {
            
    //    }
    //}

}