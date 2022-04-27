namespace E_ExtendedPropertyPatterns;

public class CoronaVarientInfo
{
    public string? VarientName { get; set; }
}

public class CoronaDetails
{
    public CoronaVarientInfo? CoronaVarientInfo { get; set; }
}

public class VirusDetection
{
    // Example 1: Nested property pattern is working in C# 10
    public static string YearOfVirusDetection(CoronaDetails coronaDetails) =>
    coronaDetails switch
    {
        { CoronaVarientInfo: { VarientName: "Novel" } } => "Found in 2019",
        { CoronaVarientInfo: { VarientName: "Delta" } } => "Found in 2020",
        { CoronaVarientInfo: { VarientName: "Omicron" } } => "Found in 2021",
        _ => "Found in 2019"
    };

    // Example 2: Extend property pattern is working in C# 10
    public static string YearOfVirusDetectionA(CoronaDetails coronaDetails) =>
    coronaDetails switch
    {
        { CoronaVarientInfo.VarientName: "Novel" } => "Found in 2019",
        { CoronaVarientInfo.VarientName: "Delta" } => "Found in 2020",
        { CoronaVarientInfo.VarientName: "Omicron" } => "Found in 2021",
        _ => "Found in 2019"
    };

}

