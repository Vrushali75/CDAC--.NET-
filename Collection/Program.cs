using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Arrays in C# using foreach loop
            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;

            ////foreach loop
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region Array Sort
            ////Array sort
            //Console.WriteLine("Enter the number of array elements you want to enter");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter array elements: ");
            //for (int i = 0; i < size; i++)
            ////foreach (int item in arr1)
            //{
            //    int val = Convert.ToInt32(Console.ReadLine());
            //    arr1[i] = val;
            //}
            ////Sorting the array using pre defined functions
            //Array.Sort(arr1);
            //Console.WriteLine("Sortde array is: ");
            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region String array inputs
            ////Accepting string inputs from user
            //string[] str = new string[3];
            //Console.WriteLine("Enter any 3 strings: ");
            //for (int i = 0; i < str.Length; i++)
            //{
            //    string val = Console.ReadLine();
            //    str[i] = val;
            //}
            //Console.WriteLine("Your entered string are: ");
            //foreach (string items in str)
            //{
            //    Console.WriteLine(items);
            //} 
            #endregion

            #region Array Search ID
            ////Accepting employee details and displaying the searched ID
            //Console.WriteLine("Enter the number of employee you want to be entered: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //Employee[] emp = new Employee[size];

            ////accepting inputs from user
            //for (int i = 0; i < size; i++)
            //{
            //    Employee e1 = new Employee();
            //    e1.SetEmpDetails();
            //    emp[i] = e1;
            //    Console.WriteLine("========================");
            //}

            ////Displaying inputes to the user
            //foreach (Employee e1 in emp)
            //{
            //    Console.WriteLine(" " + e1.GetEmpDetails());
            //    Console.WriteLine("========================");

            //}

            ////Displaying searched ID
            //Console.WriteLine("Enter ID to be searched: ");
            //int search_ID = Convert.ToInt32(Console.ReadLine());
            //bool flag = true;
            //for (int i = 0; i < size; i++)
            //{
            //    if (emp[i].ID == search_ID)
            //    {
            //        Console.WriteLine(emp[i].GetEmpDetails());
            //        Console.WriteLine("Record Found !");
            //        flag = false;
            //        break;
            //    }

            //}
            //if (flag)
            //{
            //    Console.WriteLine("Record is not found!");
            //} 
            #endregion

            Employee emp=new Employee();
            emp.ID = 1;
            emp.Name = "John";
            emp.desig = "Team Lead";

            Employee emp1 = new Employee();
            emp.ID = 2;
            emp.Name = "Tia";
            emp.desig = "Manager";

            Employee emp2 = new Employee();
            emp.ID = 3;
            emp.Name = "Louis";
            emp.desig = "Employee";

            Book book = new Book();
            book.Author = "abc";
            book.BookName = "BhagvadGita";


            Object[] obj = new Object[6];
            obj[0] = "Tejas";//String
            obj[1] = 63.23;//float
            obj[2] = 20;//integer
            obj[3] = emp1;//object of employee class
            obj[4] = book;//object of book class
            obj[5] = 'A';//char 

            foreach(Object ob in obj)
            {
                if(obj is int)
                {
                    int i = Convert.ToInt32(obj);
                    Console.WriteLine("Integer is: " + i);
                }
                if (obj is double)
                {
                    double d = Convert.ToDouble(obj);
                    Console.WriteLine("Integer is: " + d);
                }
                if (obj is string)
                {
                    string s = Convert.ToString(obj);
                    Console.WriteLine("Integer is: " + s);
                }
                if (obj is char)
                {
                    char c = Convert.ToChar(obj);
                    Console.WriteLine("Integer is: " + c);
                }
                if (obj is Employee)
                {
                    //Employee e = obj as Employee;
                    Console.WriteLine(emp.GetEmpDetails());
                }
                if (obj is Book)
                {
                    //Book b = obj as Book;
                    Console.WriteLine("Author: {0}, Book Name = {1}",book.Author,book.BookName);
                }
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {

        private int _ID;
        private string _Name;
        private string _desig;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string desig
        {
            get { return _desig; }
            set { _desig = value; }
        }

        public void SetEmpDetails()
        {
            Console.WriteLine("Enter employee ID: ");
            ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation: ");
            desig = Console.ReadLine();
        }
        public string GetEmpDetails()
        {
            string value = _ID+" " + _Name+" " + _desig;
            return value;
        }
    }
    public class Book
    {
        private string _Author;
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }


        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

    }
}
