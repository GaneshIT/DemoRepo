using System;  //namespace
using System.Collections.Generic; //namespace
using System.Linq;//namespace
using System.Text;//namespace
using System.Threading.Tasks;//namespace

namespace OOPSConsoleDemo
{
    internal class Program
    {
        public void Addition(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Addition(int a, int b,int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Addition(int a, int b,int c,int d)
        {
            Console.WriteLine(a + b + c + d);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Addition(10, 20);
            program.Addition(5, 2, 1);
            MobileConnection mobileConnectionObj = new MobileConnection();
            mobileConnectionObj.MyCalls();
            mobileConnectionObj.Dial();

            Mobile mobileObj= new Mobile(); // object creation
            mobileObj.GetMobileDetails();// function calling using object
            //mobileObj.Name
            int x;
            x = 10; //assignment

            int num1 = 10; //init value
            int num2 = 20;
            int num3 = num1 + num2;
            Console.WriteLine(num3); //print output


            Mobile mobileObj1 = new Mobile(); // object creation
            mobileObj1.GetMobileDetails();


            Console.Read();//it will read char from keyboard
        }
    }
}

//Solution can have multiple projects
//project can have multiple files.

//#include<stdio.h>
//scanf(), printf()
//namespace - hierarchical order. It will have diff kind of in built classes and methods


//.NET Compilation - Source code will be converting to MSIL(Mirosoft intermediate langugage)
                 //- MSIL code will be converting to machine code by JIT Compiler