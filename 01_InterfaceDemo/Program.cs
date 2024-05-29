using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            char c;
            do
            {
                Console.WriteLine("1)SQL Server\n2)Oracle Server\n3)MySQL Server");
                Console.WriteLine("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:

                        SQL sqlObj = new SQL();
                        Console.WriteLine("----SQL Server----");
                        Console.WriteLine("1)Insert\n2)Update\n3)Delete");
                        Console.WriteLine("Enter your database operation:");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                sqlObj.insert();
                                break;

                            case 2:
                                sqlObj.update();
                                break;

                            case 3:
                                sqlObj.delete();
                                break;
                        }
                        break;

                    case 2:

                        Oracle oracleObj = new Oracle();
                        Console.WriteLine("----Oracle Server----");
                        Console.WriteLine("1)Insert\n2)Update\n3)Delete");
                        Console.WriteLine("Enter your database operation:");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                oracleObj.insert();
                                break;

                            case 2:
                                oracleObj.update();
                                break;

                            case 3:
                                oracleObj.delete();
                                break;
                        }
                        break;

                    case 3:

                        MySQL mysqlObj = new MySQL();
                        Console.WriteLine("----MySQL Server----");
                        Console.WriteLine("1)Insert\n2)Update\n3)Delete");
                        Console.WriteLine("Enter your database operation:");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                mysqlObj.insert();
                                break;

                            case 2:
                                mysqlObj.update();
                                break;

                            case 3:
                                mysqlObj.delete();
                                break;
                        }
                        break;

                }
                Console.WriteLine("Do you want to continue? press Y/N");
                c =Convert.ToChar( Console.ReadLine());
                if (c == 'y' || c == 'Y')
                    continue;
                else
                    break;

            } while (true);
            
            Console.ReadLine();
        }
        

    }
    public class SQL
    {
        public void insert()
        {
            Console.WriteLine("Element inserted at SQL Server");
        }
        public void update()
        {
            Console.WriteLine("Element updated at SQL Server");
        }
        public void delete()
        {
            Console.WriteLine("Element deleted at SQL Server");
        }
    }
    public class Oracle
    {
        public void insert()
        {
            Console.WriteLine("Element inserted at Oracle Server");
        }
        public void update()
        {
            Console.WriteLine("Element updated at Oracle Server");
        }
        public void delete()
        {
            Console.WriteLine("Element deleted at Oracle Server");
        }
    }
    public class MySQL
    {
        public void insert()
        {
            Console.WriteLine("Element inserted at MySQL Server");
        }
        public void update()
        {
            Console.WriteLine("Element updated at MySQL Server");
        }
        public void delete()
        {
            Console.WriteLine("Element deleted at MySQL Server");
        }
    }
}
