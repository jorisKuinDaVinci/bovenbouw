using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Openbaar_Vervoer;

namespace programstartjoris2
{
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

        public void bemanTrein(Train trein)
        {
            //neem controle over de trein
            trein.giveControl(this);
        }
    }
}
