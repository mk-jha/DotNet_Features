
namespace C_ConstInterpolationString;


public static class EmployeeInfo
{
    private const string Place = "New Delhi";
    private const string ContactNumber = "88888";

    // String interpolation is working for readonly in C# 10

    public static readonly string MessageA = $"Murari Jha is belong to {Place} and his contact number is {ContactNumber}";

    // String interpolation is working for const as well in C# 10, This is the improvement here

    public const string MessageB = $"Murari is belong to {Place} and his contact number is {ContactNumber}";
}


