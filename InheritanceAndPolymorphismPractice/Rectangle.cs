using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape  // this is a derived class of shape 
    {
        private double area;


        //constructors
        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        //a derived class does NOT inherit the constructors of the base class
        //However, the constructors of the base class can be accessed
        //using the "base" keyword.
        //by including the base(4), the publicShape(int sides) is included at set sides equal to 4.

        public Rectangle(double area): base (4)
        {
            this.area = area;
        }
    }//end public class Rectangle: Shape
}//end namespace
