using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Method - Return type and no return type
//void methodname() -- no return type
//string methodname() -- return type - string type
namespace OOPSConsoleDemo
{
    //contains both abstract and non-abstract members
    //We cannot create object for abstract class
    //abstract method- Only declaratoin no definition
    public abstract class Cars
    {
        public abstract string GearSystem();
        public abstract string BreakSystem();
        public abstract string Suspension();
        public abstract int AirBags();
        public abstract string Color();
        public virtual string Wheels()
        {
            return "4 Wheels";
        }
    }
    public class Auto : Cars
    {
        public override string Wheels()
        {
            return "3 wheels";
        }
    }
    public class Bike : Cars
    {
        public override void Wheels()
        {
            return "2 whees";
        }
    }
    public class Maruti : Cars
    {
        public string ACAvailable()
        {
            return "Yes";
        }
        public override string GearSystem()
        {
            return "6 Gear";
        }
        public override string BreakSystem()
        {
            return "ABS Control";
        }
        public override string Suspension()
        {
            return "ABS Control";
        }
        public override int AirBags()
        {
            return 4;
        }
        public override string Color()
        {
            return "Red";
        }
    }
    public class ExecuteMyCars
    {
        public void Data()
        {
            Maruti marutiObj = new Maruti();
            string output = marutiObj.Color();
            if (output == "Red")
            {
                Console.WriteLine("Price: 4L");
            }
            else if (output == "Blue")
            {
                Console.WriteLine("Price: 3L");
            }
            else if (output == "Grey")
            {
                Console.WriteLine("Price: 2.5L");
            }
            Console.WriteLine(output);

            int bags = marutiObj.AirBags();
            Console.WriteLine(output);
        }
    }


    //Interface

   public interface ICars
    {
        string GearSystem(); //by default abstract keyword
        string BreakSystem();
        string Suspension();
        int AirBags();
        string Color();
       
    }
    interface ICarSystem
    {
        string SystemConfig();
    }
    public class Honda : ICars,ICarSystem
    {
        public string SystemConfig()
        {
            return "";
        }
        public int AirBags()
        {
            return 4;
        }

        public string BreakSystem()
        {
            throw new NotImplementedException();
        }

        public string Color()
        {
            throw new NotImplementedException();
        }

        public string GearSystem()
        {
            throw new NotImplementedException();
        }

        public string Suspension()
        {
            throw new NotImplementedException();
        }
    }
}

//Creditcard - Gold - PurchaseLimit(), Silver - PurchaseLimit(), Platinum - PurchaseLimit()
//Cars -
//Toyota - GearSystem(),BreakSystem(),Suspension(),AirBags()
//maruti -  GearSystem(),BreakSystem(),Suspension(),AirBags()
//Honda - GearSystem(),BreakSystem(),Suspension(),AirBags()


// File - 2wheels


// File - 3wheels
// File - 2wheels
