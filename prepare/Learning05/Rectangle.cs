 class Rectangle : Shape

{
    double _height;
    double _width;

    public Rectangle(string color,double height, double width):base(color)
    {
        _height=height;
        _width=width;

    }
    public override double GetArea()
    {
       return _height * _width;
    }
}