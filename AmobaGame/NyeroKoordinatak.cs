using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmobaGame
{
    class NyeroKoordinatak
    {
        public int X;
        public int Y;

        public NyeroKoordinatak(string koordinatak)
        {
            X = Convert.ToInt32(koordinatak.Split('_')[0]);
            Y = Convert.ToInt32(koordinatak.Split('_')[1]);
        }
    }
}
