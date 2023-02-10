 using System;
using System.IO;
using System.Text;

public class Scripture
//  Purpose to call reference class for Ref, Call Word class for mzVerse (memorizing verse)
{
   private List<Word> words = new List<Word>();
   private Reference reference;
    
    public Scripture(){}
    // Activate Scritpure Method

    public Scripture(Reference reference, string fullText){
// Method called in Program Class - meant to take _fullVerse, separate and send reference to Reference Class and store Strings
        this.reference = reference;
        foreach(string sw in fullText.Split(' ')){
            Word word = new Word(sw);
            words.Add(word);
        }
    }
    public void HideRandomWords()
    {
        int wordsHidden = 0;
        while(!IsCompletelyHidden() && wordsHidden < 3) {
            var wordCount = words.Count();
            Random r = new Random();
            int rIndex = r.Next(0,wordCount);
            Word word = words[rIndex];
            if (word.IsShown())
            {
                word.HideWord();
                wordsHidden++;
            }
        }
    }
    public string GetRenderedText(bool showOriginalText)
    {
        StringBuilder scriptureText = new StringBuilder();
        foreach(Word word in words)
        {
            scriptureText.Append(word.GetWordText(showOriginalText));
            scriptureText.Append(" ");
           
        }
        return scriptureText.ToString();
    }
    public bool IsCompletelyHidden()
    {
        bool IsCompletelyHidden = true;
        foreach (Word word in words)
        {
            if (word.IsShown())
            {
                IsCompletelyHidden = false;
            }
        }
        return IsCompletelyHidden;
    }
    public Reference Reference{
        get{ return reference; }
    }
    public void DisplayHiddenScripture(){
        HideRandomWords();
    
        string referenceText = reference.GetReferenceText();
        string scriptureText = GetRenderedText(false);
        Console.WriteLine($"{referenceText}: {scriptureText}");
    }
    public void DisplayFullScripture(){
        string referenceText = reference.GetReferenceText();
        string scriptureText = GetRenderedText(true);
        Console.WriteLine($"{referenceText}: {scriptureText}");
    }
}
