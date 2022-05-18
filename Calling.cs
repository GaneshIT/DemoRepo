using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// : - inheritance
namespace OOPSConsoleDemo
{
    public abstract class Calling //we cannot create object
    {
        public void MyCalls()
        {
            Console.WriteLine("My calls");
        }
        public abstract void Dial(); //only declaration no definition
    }
    public class MobileConnection : Calling
    {
        public override void Dial()
        {
            Console.WriteLine("Mobile call");
        }
    }
}
