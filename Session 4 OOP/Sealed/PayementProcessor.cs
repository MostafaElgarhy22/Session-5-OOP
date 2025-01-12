using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_OOP.Sealed
{
    internal sealed class PayementProcessor
    {
        public void ProcessPayement(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount}");
        }
    }

    internal class MyPayementProcessor : PayementProcessor
    {
        public new void ProcessPayement(decimal Amount)
        {

            Console.WriteLine($"Amount = {Amount + 20}");
        }
    }
}
