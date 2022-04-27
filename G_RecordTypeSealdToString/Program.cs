
// Example 1: Can be sealed a perticular override method to be access in child class in C# 10
internal record Ractangle(int length, int width)
{
    public sealed override string ToString()
    {
        return $"Height is: {length} and width is: {width}";
    }

}

internal record Squire : Ractangle
{
    protected Squire(int sideLength) : base(sideLength, sideLength)
    {
    }
    public override string ToString()
    {
        return $"Side length is: {length}";
    }
}