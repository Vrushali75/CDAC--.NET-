namespace AbtractDemo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1)PDF\n2)Word\n3)DOCX\n4)XML");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                SpecialReportFactory factory = new SpecialReportFactory();
                Report report = factory.GetReport(choice);
                report.GenerateReport();
               
                Console.WriteLine("Do you want to continue? Press Y/N");
                char ch=Convert.ToChar(Console.ReadLine());
                if (ch == 'y' || ch == 'Y')
                    continue;
                else
                    break;
            } while (true);
            Console.ReadLine();
        }
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();

        }
    }
    public abstract class SpecialReport : Report
    {    
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            Save();
            ReValidate();
        }

    }

    //Factory Pattern
    public class SpecialReportFactory //Factory Class
    {
        public Report GetReport(int choice)
        {
            if (choice == 1)
                return new PDF();
            else if (choice == 2)
                return new Word();
            else if (choice == 3)
                return new DOCX();
            else if (choice == 4)
                return new XML();
            else
                return null;

        }
    }

    //Class PDF inheriting Report class
    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }

    //class Word inheriting Report class
    public class Word : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Word Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("Word Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("Word Saved");
        }
    }

    //class TXT inheriting Report class

    public class TXT : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("TXT Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("TXT Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
    }

    //class DOCX inheriting Report class
    public class DOCX : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }

    //class XML inheriting SpecialReport class having Revalidate method
    public class XML :SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("XML Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("XML Saved");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("XML ReValidated");
        }
    }

}
