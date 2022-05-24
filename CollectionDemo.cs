using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Collectoins: 1. Non-Generic Collection, 2. Generic Collection
namespace OOPSConsoleDemo
{
    public class student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
    }
    public class CollectionDemo
    {
        public void Data()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("E01", 1000);
            data.Add("E02", 3000);
            data.Add("E03", 5000);
            data.Add("E04", 2000);
            data.Add("E05", 7000);

            foreach (var item in data)
            {

            }

            List<student> students = new List<student>();
            student studentObj = new student();
            studentObj.Id = 1;
            studentObj.name = "Ganesh";
            studentObj.marks = 10;
            students.Add(studentObj);

            studentObj = new student();
            studentObj.Id = 2;
            studentObj.name = "Ganesh";
            studentObj.marks = 210;
            students.Add(studentObj);

            studentObj = new student();
            studentObj.Id = 3;
            studentObj.name = "Ganesh";
            studentObj.marks = 109;
            students.Add(studentObj);

            Add<int>(10, 20);
            Add<string>("10", "20");
            Add<float>(10, 20);
            Add<decimal>(10, 20);
            //Add("10",)
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Id);
                Console.WriteLine(students[i].marks);
                Console.WriteLine(students[i].name);
            }

            #region arraylist
            int[] a = new int[10];
            string[] b = new string[10];
            object[] c = new object[10];
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(200);//[3]
            arrayList1.Add(300);//[4]
            arrayList1.Add(200);//[5]
            //ArrayList, Stack, queue
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100); //[0]
            arrayList.Add("Ganesh");//[1]
            arrayList.Add(5000.00);//[2]
            arrayList.AddRange(arrayList1);

            int val1 = Convert.ToInt32(arrayList[0]);
            //int val2 = arrayList[1];
            arrayList.RemoveRange(1, 2);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            ArrayList arrayList2 = new ArrayList();
            Array array = c;
            arrayList.CopyTo(array);

            //[0] 100
            //[1] 200
            //[2] 100
            #endregion
            #region stack
            Stack stack = new Stack();//LIFO
            stack.Push(111);
            stack.Push(112);
            stack.Push(113);
            stack.Push(114);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            #endregion
            #region Queue
            Queue queue = new Queue();//FIFO
            queue.Enqueue(112);
            queue.Enqueue(123);

            Console.WriteLine(queue.Dequeue());
            #endregion
        }
        //a=10,b=20
        //public void Add(int a,int b)
        //{
        //    Console.WriteLine(a + b);
        //}
        //public void Add(string a, string b)
        //{
        //    Console.WriteLine(a + b);
        //}
        //public void Add(float a, float b)
        //{
        //    Console.WriteLine(a + b);
        //}

        public void Add<T>(T a,T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x + y);
        }       
    }
}
