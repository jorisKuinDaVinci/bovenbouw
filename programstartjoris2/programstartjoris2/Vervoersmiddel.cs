using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Openbaar_Vervoer;

namespace programstartjoris2
{
    public class Vervoersmiddel
    {
        public int aantalWielen;
        public int aantalPlaatsen;

        public Vervoersmiddel(int aantalWielen, int aantalPlaatsen)
        {
            this.aantalWielen = aantalWielen;
            this.aantalPlaatsen = aantalPlaatsen;
        }

        public int rijden()
        {
            return 130;
        }

        public int remmen()
        {
            return 0;
        }
    }
}
