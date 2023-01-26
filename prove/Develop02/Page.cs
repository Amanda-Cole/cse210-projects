using System;

public class Page
{
    public string _promptQ;
    public string _date;
    public string _response;

    public void DisplayGetFullEntry()
    {
        // ALC write all to console.

        Console.WriteLine($"{_date}: {_promptQ}");
        Console.WriteLine($"> {_response}");
    }
}