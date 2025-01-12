using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_OOP.Abstraction
{
    // Abstract class 'Is A'
    // is a Partial Implementation for other types of classes.
    // is a Container for common code "Implemened Members, Abstracted Members" among multiple types of classes.
    // U can not create an object from an abstract class [it is not Fully Implemented]
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract property
        public abstract double Perimeter { get; } // read only property and Auto Implemented Property.


        // Abstract method
        public abstract double calculateArea();

    }

    class Rectangle : Shape // will inherit the properties and methods of the Shape class and implement the abstract method
                            //concrete class
    {
        public override double Perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }
        public override double calculateArea()
        {
            return Dim01 * Dim02;
        }
    }
    abstract class RectBase : Shape
    {
        public override double Perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }
        public override double calculateArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Square : Shape
    {
        public override double Perimeter
        {

            get
            {
                return Dim01 * 4;
            }
        }
        public override double calculateArea()
        {
            return Dim01 * Dim01;
        }

    }

    // concrete class
    class circle : Shape 
    {
        public circle(double radius)
        {
            this.Dim01 = this.Dim02 = radius;
        }
        public override double Perimeter
        {
            get { return 2 * Math.PI * Dim01; }
        }

        public override double calculateArea()
        {
            return Math.PI * Dim01 * Dim01;
        }
    }

   
}
