using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Moq framework
namespace EmployeeBonus
{
    public interface IOperations
    {
       double add(double a, double b);
       double sub(double a, double b);
    }
}
