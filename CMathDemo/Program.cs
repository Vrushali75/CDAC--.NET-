namespace CMathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColdDrink coldDrink = new ColdDrink();
            Console.WriteLine(coldDrink.GetDrink());
            HotDrink hotDrink = new HotDrink();
            Console.WriteLine(hotDrink.GetDrink());
            MockTails mockTails = new MockTails();
            Console.WriteLine(mockTails.GetDrink()); 


        }
    }
    public interface Idrink
    {
        string GetDrink();
    }
    public class ColdDrink:Idrink
    {
        public string GetDrink()
        {
            return "Coke";
        }

    }
    public class HotDrink:Idrink
    {
        public string GetDrink()
        {
            return "Tea";

        }
    }
    public class MockTails: Idrink
    {
        public string GetDrink()
        {
            return "Mojito";
        }
    }

    }


