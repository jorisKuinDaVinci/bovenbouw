namespace Openbaar_Vervoer;

public class Person
{
    public string name;
    public string lastName;
    public int age;

    public Person(string name, string lastName, int age)
    {
        this.name = name;
        this.lastName = lastName;
        this.age = age;
    }

    public void bemanVoertuig(Vervoersmiddel vervoersmiddel)
    {
        vervoersmiddel.giveControl(this);
    }
    
}