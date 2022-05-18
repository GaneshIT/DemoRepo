using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleDemo
{
    public class Mobile
    {
        private int IMENo;
        public string Name; //attribute/property/variable

        public void GetMobileDetails()  //functions
        {
            IMENo = 123;
            Name = "MyMobile";
            Console.WriteLine(Name);
            Console.WriteLine(IMENo);
        }
    }
}
