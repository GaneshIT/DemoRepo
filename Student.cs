using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleDemo
{
    //data members
    //properties
    //constructors -  Class name and function name will be same name.
    //Function will call automatically when object creating
    public class Student
    {
        public static string grade;
        public string name; //data member
        public int StudeId { get; set; }   //property
        public string StudName { get; set; }
        public string DeptName { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }

        static Student()  //static constructor
        {
            grade = "A";
            Console.WriteLine(grade);
        }
        public Student()
        {
            this.StudeId = 0;
            this.StudName = "";
            this.DeptName = "";
            this.Course = "";
            this.Marks = 0;
        }
        public Student(int studId,string studName,string deptName,string course,int marks)
        {
            this.StudeId = studId;
            this.StudName = studName;
            this.DeptName = deptName; 
            this.Course = course;
            this.Marks = marks; 
        }
        public Student(int studId)
        {

        }
        public void GetStudentDetails()
        {
            Console.WriteLine(grade);
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
        }

    }
    public class MainClass
    {
        //Boxing and Unboxing
        public void Data()
        {
            int a = 10;  //value type
            int b = a;  //value type
            string c = b.ToString();  //value type

            //object - reference type
            object d = b; //boxing - value type to reference type
            object e = c;
            object f = a;

            int myvalue = Convert.ToInt32(e);  //unboxing reference type to value type
            // \n
            //Student studentObj = new Student();
            //Console.Write("Enter stud id:");
            //studentObj.StudeId =Convert.ToInt32(Console.ReadLine()); //To read input from user or get input from user
            
            //Console.Write("Enter stud name:");
            //studentObj.StudName = Console.ReadLine();
            
            //Console.Write("Enter stud deptname:");
            //studentObj.DeptName = Console.ReadLine();


            //Console.WriteLine("Student Details:");
            //Console.WriteLine("StudId: " + studentObj.StudeId);
            //Console.WriteLine("StudName: " + studentObj.StudName);
            //Console.WriteLine("StudDept: " + studentObj.DeptName);

        }
    }
}
