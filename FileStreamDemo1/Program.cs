using System.Runtime.Serialization.Formatters.Binary;

namespace FileStreamDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\IET\Desktop\240345920103_104\.NET\103_104(.NET)\STREAM Demo\StreamFileDemo1.txt";
            string filepath1 = @"C:\Users\IET\Desktop\240345920103_104\.NET\103_104(.NET)\STREAM Demo\StreamFileDemo.txt";
            FileStream fs = null;
            if(File.Exists(filepath) ) 
            {
                fs = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath1, FileMode.CreateNew, FileAccess.Write);
            }

            Customer cust = new Customer();
            Console.WriteLine("Enter Customer ID: ");
            cust.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            cust.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Address: ");
            cust.Address = Console.ReadLine();

            BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, cust);
            fs.Close();
            Console.WriteLine("Done");



        }
    }
    public class Customer
    {
        private int _ID;
        private string _Name;
        private string _Address;

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

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
