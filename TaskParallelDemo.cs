using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPSConsoleDemo
{
    //Parallel programming is a programming technique wherein the execution flow of the application
    //is broken up into pieces that will be done at the same time
    //(concurrently) by multiple cores, processors, or computers for the sake of better performance.

    //Synchronous programming
    //Asynchronus programming

    //What is a Thread?
    //A Thread is the smallest unit of code to which an operating system allocates CPU time.
    //In multithreading, a single process has multiple threads of execution.
    //If the system has multiple cpu’s then it can run in parallel.

    //1 Data Parallel, 2. Task Parallel

    //lambda expression =>
    public class TaskParallelDemo
    {
        public void DisplayItem(string item)
        {
            Console.WriteLine(item);
        }
        public void ShowData()
        {
            List<string> datalist = new List<string>()
            {
                "Mouse","Keyboard","Pendrive","HardDisk"  // 100000
            };
            foreach (var item in datalist)
            {
                Console.WriteLine(item);
            }
            //Parallel.ForEach(datalist,item=>DisplayItem(item));

            //ShowEmployeeReport();  //5min
            //ShowCustomerReport(); //10min
            Parallel.Invoke(ShowEmployeeReport, ShowEmployeeReport);

        }
        public void ShowCustomerReport()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ShowCustomerReport: "+i);
                Thread.Sleep(1000);
            }
        }
        public void ShowEmployeeReport()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ShowEmployeeReport: "+i);
                Thread.Sleep(1000);
            }
        }

    }

    
}
