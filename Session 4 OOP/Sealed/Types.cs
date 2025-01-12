using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_OOP.Sealed
{
    internal class Types
    {
        class Parent
        {
            public virtual int Salary {  get; set; }
        }

        class Child : Parent
        {
            public override int Salary { get; set; }
        }

        sealed class GrandChild : Child    // sealed class means i can't inherit from this class.
        {
            public new int salary
            {
                get { return base.Salary; }
                set { base.Salary = value; }
            }
        }
        
    }
}
