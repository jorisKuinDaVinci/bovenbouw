namespace Openbaar_Vervoer;

public class Vervoersmiddel
{
    public int aantalWielen;
    public int aantalPlaatsen;
    public Person conducteur;
    public static int aantalCheckins = 0;

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
    
    public void giveControl(Person nieuweConducteur)
    {
        this.conducteur = nieuweConducteur;
    }

    public bool doCheckin()
    {
        Vervoersmiddel.aantalCheckins++; // this.aantalCheckins = this.aantalCheckins + 1;
        return true;
    }
}