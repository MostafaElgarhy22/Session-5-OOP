using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_OOP.Abstraction
{
    // Abstract class
    abstract class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Age { get; set; }
        public string? Address { get; set; }

        public abstract void DoWork();
    }
    class FullTimeEmployee : Employee
    {
     // concrete class   
        public override void DoWork()
        {
            Console.WriteLine("Full Time Employee is working");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine("Part Time Employee is working");
        }
    }
}
