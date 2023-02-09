 using System;
using System.IO;

 public class Scripture
//  To call reference class for Ref, Call Word class for mzVerse (memorizing verse)
{
   private List<string> verses = new List<string>();
   verses "1 Nephi/1/9/10/ And it came to pass that he saw One descending out of the midst of heaven, and he beheld that his luster was above that of the sun at noon-day.% And he also saw twelve others following him, and their brightness did exceed that of the stars in the firmament.";

    
   //private get_bookName
        
    public List<string> Verses { 
        get {return verses;}
        set {verses = value;}
    }

    public Scripture(Reference reference, string text) {

    }

}

 
 
//  class ScriptureReference{
    
//         private List<Verse> verses;
//         private int wordsScrambled;

//         public ScriptureReference(string scripture, char separator)
//         {
//             verses = scripture
//                 .Split(',')
//                 .Select(v => new Verse(v.Trim(), separator))
//                 .ToList();

//             wordsScrambled = 0;
//         }

//         public ScriptureReference(string scripture){
//             : this(scripture, ' ')
//         {
//     }
    //     public void PrintScrambledVerses()
    //     {
    //         wordsScrambled = 0;
    //         foreach (var verse in verses)
    //         {
    //             Console.WriteLine(verse.Scramble(ref wordsScrambled));
    //         }
    //     }
    // }
