using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizardOne = new Wizard(true);
            HogwartsStudent longbottom = new HogwartsStudent(7);
            DeathEater malfoy = new DeathEater();

            wizardOne.MakeMagic();
            longbottom.MakeMagic();
            malfoy.MakeMagic();
        }//end of main
    }//end of class program
}//end of namespace
