namespace Openbaar_Vervoer;

public class Tram : Vervoersmiddel
{
    private int aantalOVPaaltjes;

    public Tram(int wielAantal, int plaatsen, int aantalPaaltjes) : base(wielAantal, plaatsen) 
    {
        this.aantalOVPaaltjes = aantalPaaltjes;
    }

    public int getAantalOVPaaltjes()
    { 
        return this.aantalOVPaaltjes; 
    }

    public void setAantalOVPaaltjes(int newAantalOVPaaltjes)
    {
        this.aantalOVPaaltjes = newAantalOVPaaltjes;
    }
}