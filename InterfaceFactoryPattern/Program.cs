namespace InterfaceFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)SQL Server\n2)Oracle Server\n3)MySQL Server\n");
            Console.WriteLine("Enter your choice: ");
            int dbChoice=Convert.ToInt32(Console.ReadLine());
            DatabaseFactory databaseFactory=new DatabaseFactory();
            IDatabase db = databaseFactory.GetDataBase(dbChoice);

            do
            {


                Console.WriteLine("Enter your Database operation: ");
                Console.WriteLine("1)Insert\n2)Update\n3)Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
               
                switch (opChoice)
                {
                    case 1:
                        db.Insert();
                        break;

                    case 2:
                        db.Update();
                        break;

                    case 3:
                        db.Delete();
                        break;
                } 
               
                Console.WriteLine("Do you want to continue? Press Y/N");
                char ch=Convert.ToChar(Console.ReadLine());
                if (ch == 'Y' || ch == 'y')
                    continue;
                else
                    break;
            } while (true);
        }
    }
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }

    //Factory Pattern

    public class DatabaseFactory// factory class
    {
        public IDatabase GetDataBase(int dbChoice)
        {
            if (dbChoice == 1)
            {
                return new SQLServer();
            }
            else if (dbChoice == 2)
            {
                return new OracleServer();
            }
            else if (dbChoice == 3)
            {
                return new MySQLServer();
            }
            else
                return null;
        }
    }

    //Implementation for SQL server operations
    public class SQLServer:IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Element inserted at SQL Server");
        }
        public void Update()
        {
            Console.WriteLine("Element updated at SQL Server");
        }
        public void Delete()
        {
            Console.WriteLine("Element deleted at SQL Server");
        }
    }

    //Implementation for Oracle server operations
    public class OracleServer:IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Element inserted at Oracle Server");
        }
        public void Update()
        {
            Console.WriteLine("Element updated at Oracle Server");
        }
        public void Delete()
        {
            Console.WriteLine("Element deleted at Oracle Server");
        }
    }


    //Implementation for MySQL server operations
    public class MySQLServer:IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Element inserted at MySQL Server");
        }
        public void Update()
        {
            Console.WriteLine("Element updated at MySQL Server");
        }
        public void Delete()
        {
            Console.WriteLine("Element deleted at MySQL Server");
        }
    }

}
