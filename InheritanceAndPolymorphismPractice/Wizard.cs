using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Wizard // this is the base class - everything else is "based" off of this class.
    {
        //fields
        private bool isGood;

        //Properties
        public bool IsGood
        {
            get { return this.isGood; }
            set { this.isGood = value; }
        }

        //Constructors
        public Wizard()
        {
            //default constructor
        }

        public Wizard(bool isGood)
        {
            this.isGood = isGood;
        }

        //method
        public virtual void MakeMagic()
        {
            Console.WriteLine("Wingardium Leviosa");
        }
    }
}
