namespace Openbaar_Vervoer;

public class Tram : Vervoersmiddel
{
    public int aantalOVPaaltjes;

    public Tram(int wielAantal, int plaatsen, int aantalPaaltjes) : base(wielAantal, plaatsen) 
    {
        this.aantalOVPaaltjes = aantalPaaltjes;
    }
}