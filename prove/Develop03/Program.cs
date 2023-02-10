using System;


partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to memorize a scripture from Lehi, Nephi, Alma, Helaman, Isaiah, or Proverbs?");
        string choice = "";
        choice = (Console.ReadLine());
        string uChoice = choice.ToUpper();
        Console.Clear();
        Library library = new Library();
        string _fullVerse = library.getScripture(uChoice);
               
        List<string> versesParts =  _fullVerse
            .Split('/')
            .ToList();
        Reference reference = null;
        if (versesParts[3] == "0") {
            reference = new Reference(versesParts[0],versesParts[1],versesParts[2]);
        } else {
            reference = new Reference(versesParts[0],versesParts[1],versesParts[2],versesParts[3]);
        }
        Scripture _activeVerse = new Scripture(reference, versesParts[4]);
         _activeVerse.DisplayFullScripture();
        
        Console.WriteLine("\n");
        Console.WriteLine("Hit enter to hide random words or type 'quit' to end program.");
        
        string response = Console.ReadLine();
        while (response != "quit") {
            Console.Clear();
            _activeVerse.DisplayHiddenScripture();
            Console.WriteLine("\n");
            Console.WriteLine("Hit ENTER to hide random words or type 'quit' to end program.");
            response = Console.ReadLine();
            if(_activeVerse.IsCompletelyHidden()){
                response = "quit";
                Console.WriteLine("Great Job!");
            }
        }
    }
}
