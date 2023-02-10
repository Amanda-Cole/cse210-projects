using System;


partial class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Would you like to memorize a scripture from Lehi, Nephi, Alma, Helaman, or Isaiah?");
        string choice = "";
        choice = (Console.ReadLine());
        string uChoice = choice.ToUpper();

        List<string> _Library = new List<string>();

        _Library.Add("Alma/32/21/0/ And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        _Library.Add("1 Nephi/3/7/0/ And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
        _Library.Add("1 Nephi/1/9/10/ And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.; And he also saw twelve others following him, and their brightness did exceed that of the stars in the firmament.");

        string _fullVerse = "";
        if (uChoice == "LEHI"){
            _fullVerse = _Library[2];
        }
        if (uChoice == "NEPHI"){
            _fullVerse = _Library[1];
        }
        if (uChoice == "ALMA"){
            _fullVerse = _Library[3];
        }
        
// Send choice to Class Scripture
    //    Console.WriteLine(_fullVerse);
// Scripture class, variable _activeVerse = new Object Scripture(method) using _fullVerse
        List<string> versesParts = _fullVerse
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
            response = Console.ReadLine();
            if(_activeVerse.IsCompletelyHidden()){
                response = "quit";
            }
        }
    }
}
