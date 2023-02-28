// abstract class because of abstract method
public abstract class Shape
{
    // add variable
    private string _color = "";

    // getter for color
    public string GetColor()
    {
        return _color;
    }

    // setter for color - no return so void
    public void SetColor(string color)
    {
        _color=color;
    }

    // Constructor Shape
    public Shape(string color)
    {
        _color = color;
    }
// virtual method for GetArea - double means large float number  **virtual/override returns something**  Abstract is empty override and return in sub class
    public abstract double GetArea();
}