using System;
using System.IO;

public class Journal 
{
   PromptGenerator _promptGen = new PromptGenerator();
   List<Page> _entries = new List<Page>();

// from layout - AddPage function to call CLASS PAGE
   public void AddPage()
   {
        string _prompt = _promptGen.PullRandomPrompt();
        Console.WriteLine();
        Console.WriteLine(_prompt);
        Console.Write(">");
        string response = Console.ReadLine();
        string pageDate = DateTime.Now.ToShortDateString();
        Page page = new Page();
        page._date = pageDate;
        page._promptQ = _prompt;
        page._response = response;
        _entries.Add(page);
   }

   public void Display(){
        foreach(Page p in _entries){
            Console.WriteLine();
            p.DisplayGetFullEntry();
            Console.WriteLine();
        }
   }
// Load  - clearing current journal entries and loading from file
   public void Load(){

        string fileName = "journal.txt";
        _entries.Clear();
        foreach (string line in System.IO.File.ReadLines(fileName))
        {        
            string[] entryParts = line.Split("%");
            Page p = new Page();
            p._date = entryParts[0];
            p._promptQ = entryParts[1];
            p._response = entryParts[2];
            _entries.Add(p);
        }
   }

   public void Save(){

        string fileName = "journal.txt";
        if (File.Exists(fileName)) {
            File.Delete(fileName);
        }
        using (StreamWriter writer = File.CreateText(fileName))  
        {  
            foreach(Page p in _entries){
                writer.WriteLine($"{p._date}%{p._promptQ}%{p._response}");
            }
        }   
   }
   
}

