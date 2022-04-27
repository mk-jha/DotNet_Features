public struct Ractangle
{
    //Example : Parametrless constuctor working with struct type in C# 10
    public Ractangle()
    {
        Length = 40; // Default value 
        Width = 30;  // Default value
    }
    public Ractangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public int Length { get; set; }
    public int Width { get; set; }
}