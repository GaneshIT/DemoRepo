using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File handling
//File handling

namespace OOPSConsoleDemo
{
    public class FileHandlingDemo
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Training\DotnetAzureTraining\myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("Welcome to training");
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
            
        }
        public void ReadFile()
        {

            //How to declare array
            string[] values = { "A", "B", "C", "D", "E" }; //dynamic array
            int[] studId = new int[2]; //fixed array
            string[] studName = new string[2];
            int[] studMarks = new int[2];
            FileStream fileStreamObj = new FileStream(@"C:\Training\DotnetAzureTraining\myfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            streamReaderObj.ReadLine();
            Console.WriteLine("StudId\tName\tMarks");
            while (streamReaderObj.Peek()>0) 
            {
                string line = streamReaderObj.ReadLine(); //1,A,20    ','
                string[] myStrs = line.Split(',');
                //myStrs[0]="1"
                //myStrs[1]="A"
                //myStrs[2]="20"
                Console.WriteLine(myStrs[0] + "\t" + myStrs[1] + "\t" + myStrs[2]);
            }
            Console.WriteLine("*********");
            Console.WriteLine("Read operation completed");
        }
    }
}
