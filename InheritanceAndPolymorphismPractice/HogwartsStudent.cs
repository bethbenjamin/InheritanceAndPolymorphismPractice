using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class HogwartsStudent : Wizard  //this is a derived class from Wizard base
    {
        //fields
        private int yearInSchool;

        //Properties
        public int YearInSchool
        {
            get { return this.yearInSchool; }
            set { this.yearInSchool = value; }
        }

        //Constructors
        public HogwartsStudent()
        {
            //default constructor
        }

        public HogwartsStudent(int yearInSchool)
        {
            this.yearInSchool = yearInSchool;
            this.IsGood = true;
        }

        //Methods
        public override void MakeMagic()
        {
            Console.WriteLine("Accio book");
        }


        public int Study()
        {
            return yearInSchool++;
        }

        
    }
}