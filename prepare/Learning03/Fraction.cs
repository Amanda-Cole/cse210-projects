using System;

public class Fraction
{
    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(int n){
        _numerator = n;
        _denomenator = 1;
    }

    public Fraction(int n, int d){
        _numerator = n;
        _denomenator = d;
        
    }

    public string GetFraction()
    {
        string text = $"{_numerator}/{_denomenator}";
        return text;
    }
    
    // returns numerator/denomenator in decimal form
    public double GetDecimalValue(){
        return (double)_numerator / (double)_denomenator;
    }


}