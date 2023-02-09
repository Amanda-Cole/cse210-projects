using System;


partial class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Would you like to memorize a scripture from Lehi, Nephi, Alma, Helaman, or Isaiah?");
        string choice = "";
        choice = (Console.ReadLine());
        
        

        List<string> _Library = new List<string>();

            _Library.Add("Alma/32/21/0/ And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
            _Library.Add("1 Nephi/3/7/0/ And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
            _Library.Add("1 Nephi/1/9/10/ And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.% And he also saw twelve others following him, and their brightness did exceed that of the stars in the firmament.");

        string _fullVerse = ("");
        if (choice == "Lehi"){
            _fullVerse = _Library[2];
            //_fullVerse = ("1 Nephi/1/9/10/ And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.% And he also saw twelve others following him, and their brightness did exceed that of the stars in the firmament.");
        }
        if (choice == "Nephi"){
            _fullVerse = _Library[1];
            _fullVerse = ("1 Nephi/3/7/0/ And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
        }
        if (choice == "Alma"){
            _fullVerse = ("Alma/32/21/0/ And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        }
        
// Send choice to Class Scripture
    //    Console.WriteLine(_fullVerse);

        Scripture _activeVerse = new Scripture(_fullVerse);
_activeVerse.Verses = new List<string>();
    }
}
















// namespace ScriptureScramble
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a scripture reference with multiple verses (separated by commas):");
//             string scripture = Console.ReadLine();

//             ScriptureReference reference;
//             if (scripture.Contains(':'))
//             {
//                 reference = new ScriptureReference(scripture, ':');
//             }
//             else
//             {
//                 reference = new ScriptureReference(scripture, ' ');
//             }

//             reference.PrintScrambledVerses();

//             Console.WriteLine("Press Enter to scramble again, or any other key to exit.");
//             while (Console.ReadKey().Key == ConsoleKey.Enter)
//             {
//                 reference.PrintScrambledVerses();
//                 Console.WriteLine("Press Enter to scramble again, or any other key to exit.");
//             }
//         }
//     }

   



