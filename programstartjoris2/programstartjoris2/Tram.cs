using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Openbaar_Vervoer;

namespace programstartjoris2
{
    public class Tram : Vervoersmiddel
    {
        public int aantalOVPaaltjes;

        public Tram(int wielAantal, int plaatsen, int aantalPaaltjes) : base(wielAantal, plaatsen)
        {
            this.aantalOVPaaltjes = aantalPaaltjes;
        }
    }
}
