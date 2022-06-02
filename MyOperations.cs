using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBonus
{
    //UNIT Testing- Xunit, Nunit, MsUnit

    //Test cases
    //TestCase1 Addition  - ExpectedOutput, ActualOutput
    //TestCase2 Subtraction
    public class MyOperations : IOperations
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double sub(double a, double b)
        {
            return a - b;
        }
    }
}
