using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programstartjoris2
{
    public class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public Person conducteur;

        public Train(int wielAantal, int plaatsen)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsen;
        }

        public int rijden()
        {
            return 130;
        }

        public int remmen()
        {
            return 0;
        }

        public void giveControl(Person nieuweConducteur)
        {
            this.conducteur = nieuweConducteur;
        }
    }
}
