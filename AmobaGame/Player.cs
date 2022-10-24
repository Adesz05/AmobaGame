using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmobaGame
{
    class Player
    {
        public string Nev;
        public char MivelVan;
        public int Pontszam;

        public Player(string nev, char mivelvan, int pontszam)
        {
            Nev = nev;
            MivelVan = mivelvan;
            Pontszam = pontszam;
        }
    }
}
