using System.Collections;
using System.Net;
using System.Xml.Linq;

namespace CSharp_Features
{
    internal class Program
    {
        public delegate bool MyDelegate(int x);
        static void Main(string[] args)
        {
            #region Partial Class
            ////Partial Class
            //CMath cmath = new CMath();
            //Console.WriteLine("Addition is:{0} ",cmath.Add(20,10));
            //Console.WriteLine("Subtraction is:{0} ",cmath.Sub(20,10)); 
            #endregion

            #region Nullable Types
            //int ? i= null;
            //Nullable<int> Age = 40;

            //if(Age.HasValue) 
            //{
            //    Console.WriteLine("Age is {0}",Age);
            //}
            //else
            //{
            //    Console.WriteLine("Age cannot be null");
            //} 
            #endregion

            #region Normal Call through delegate
            //MyDelegate del = new MyDelegate(Check);
            //Console.WriteLine("Enter any integer value: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool result = del(num);//call through delegate
            //if (result)
            //{
            //    Console.WriteLine("{0} is greater than 10",num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is smaller than 10",num);
            //} 
            #endregion

            #region Anonymous Method
            //MyDelegate del = delegate (int i) { return i > 10; };//Anonymous method

            ////MyDelegate del = delegate (int i)
            ////                         {
            ////                             return i > 10;
            ////                         };

            //Console.WriteLine("Enter any number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool result = del(num);
            //if (result)
            //    Console.WriteLine("{0} is greater than 10", num);
            //else
            //    Console.WriteLine("{0} is smaller than 10",num); 
            #endregion

            #region Lambda Expression
            //MyDelegate del = (i) => { return i == 10; };
            ////(=>) goes to operator, short syntax for anonymous method
            ////
            ////MyDelegate del = (i) => { 
            ////                            return i == 10; 
            ////                        };

            //bool result = del(10);
            //Console.WriteLine(result); 
            #endregion

            #region Object Initializer
            ////Declaration and initilization of the object at the same time
            //int[] arr2 = new int[] { 100, 200, 300, 400 };
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //Employee emp = new Employee() { ID = 1, Name = "Marrie" ,Address = "New York" };
            //Console.WriteLine("ID = {0}, Name = {1}, Address = {2}",emp.ID,emp.Name,emp.Address);

            //Employee emp2 = new Employee() {ID=2 ,Address="America"};
            //Console.WriteLine("ID = {0},  Address = {1}", emp2.ID, emp2.Address);

            //ArrayList list = new ArrayList() { emp, "Vrushali", 22.03, 623 };
            //foreach(Object obj in list)
            //{
            //    if(obj is Employee)
            //    {
            //        Console.WriteLine("ID = {0}, Name = {1}, Address = {2} ", emp.ID, emp.Name, emp.Address);
            //    }
            //    if(obj is int)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //    if (obj is double)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //    if (obj is string)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //} 
            #endregion
            


            ArrayList arr = new ArrayList();
            foreach (int element in arr)
            {

            }

            //object[] objarr = new object[];
            Week week = new Week();
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();
        }
        public static bool Check(int i)
        {
            return i > 10;
        }
    }
    public class Week : IEnumerable
    {
        private string[] Days = new string[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Days.Length; i++)
            //foreach(string str in Days)
            {
                yield return Days[i];
            }
        }



    }

    public class Employee
    {
        private int _ID;
        private string _Name;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }
}
