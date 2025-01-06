using Session_4_OOP.Abstraction;

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


        }
    }
}
