using System;
using System.Collections.Generic;

public class PromptGenerator
{

    List<string> promptList = new List<string>();
    public PromptGenerator() {
        promptList.Add("What is your favorite thing about today? ");
        promptList.Add("What is your favorite color and why?");
        promptList.Add("What would you do with $5 million Dollars?");
        promptList.Add("What is a favorite childhood memory with your Mom?");
        promptList.Add("Where in the world would you like to travel and why?");
        promptList.Add("Tell yourself something positive about today?");
        promptList.Add("What is the biggest thing you accomplished today?");
        promptList.Add("What are five things you are grateful for?");
        promptList.Add("What do you need more of in life?");
    }
    
    public string PullRandomPrompt() {
       var countprompt = promptList.Count();

        Random r = new Random();
        int rInt = r.Next(0,countprompt-1);

        string _promptQ = promptList[rInt];

        return _promptQ;
    }
}
    
