using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class DeathEater : Wizard  // this is the derived class from Wizard - the base
    {
        //fields 
        private bool hasDarkMark;

        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor
        public DeathEater() : base(false) 
        {

        }

        //methods
        public override void MakeMagic() //override method overrides the base method called to create their own in that method
        {
            base.MakeMagic(); // if you just left this in, everything from the MakeMagic base would go first, then the override.
            Console.WriteLine("Crucio!");
        }
    }
}