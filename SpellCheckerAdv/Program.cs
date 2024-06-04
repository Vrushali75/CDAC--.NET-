using System.Security.Cryptography.X509Certificates;

namespace SpellCheckerAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notepad notepad = new Notepad(null);
            notepad.SpellCheck();
        }
    }
    public interface ISpellChecker
    {
        public void DoSpellCheck();
    }

    public class Notepad
    {
        ISpellChecker _somespellchecker = null;
        SpellCheckerFactory factory=new SpellCheckerFactory();
        public Notepad(ISpellChecker checker)
        {
            if(checker == null)
            {
                _somespellchecker = factory.GetSpellChecker("eng");
            }
            else
            {
                _somespellchecker = checker;
            }
           
        }
        public void SpellCheck()
        {
            _somespellchecker.DoSpellCheck();
        }
    }


    //Factory Pattern
    public class SpellCheckerFactory//Factory Class
    {
        public ISpellChecker GetSpellChecker(string lang)
        {
            ISpellChecker spellchecker = null;
            switch(lang)
            {
                case "eng":
                    spellchecker=new EnglishSpellChecker();
                    break;

                case "french":
                    spellchecker=new FrenchSpellChecker();
                    break;

                case "german":
                    spellchecker=new GermanSpellChecker();
                    break;

                default:
                    spellchecker = new EnglishSpellChecker();
                    break;

            }
            return spellchecker;
        }
    }



    public class EnglishSpellChecker:ISpellChecker
    {
        public void DoSpellCheck() 
        {
            Console.WriteLine("English spell checker done");
        }
    }
    public class FrenchSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("French spell checker done");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("German spell checker done");
        }
    }
    public class HindiSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Hindi spell checker done");
        }
    }

}
