using Session_4_OOP.Abstraction;
using Session_4_OOP.Static;

namespace Session_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP Pillars 4.Abstraction
            // Abstraction is the concept of hiding the complex implementation details and showing only the necessary features of the object.

            // Shape shape;
            // Declaring a reference of type Shape.
            //This reference can Hold and addrees for objects of any class that is derived from Shape.

            //shape = new Shape(); // invalid
            #region rectangle
            //shape = new Rectangle();
            //shape.Dim01 = 10;
            //shape.Dim02 = 20;
            //System.Console.WriteLine(shape.calculateArea());
            //System.Console.WriteLine(shape.Perimeter);
            #endregion
            #region Square
            //shape = new Square();
            //shape.Dim01 = 20;
            //System.Console.WriteLine(shape.calculateArea());
            //System.Console.WriteLine(shape.Perimeter);
            #endregion
            #region Circle
            //shape = new circle(100);
            //System.Console.WriteLine(shape.calculateArea());
            #endregion
            #endregion
            #region Static[class, Method,Constructor,Property,Attribute] and Constant
            //Utility U01 = new Utility(1,2);
            //Utility U02 = new Utility(5,10);

            // The result of calling this method will not be differnt by the Difference of object space.
            //Console.WriteLine(U01.CmToInch(100));
            //Console.WriteLine(U02.CmToInch(100));

            // Console.WriteLine(U01.CalcCircleArea(10)); 
            #endregion


        }
    }
}
