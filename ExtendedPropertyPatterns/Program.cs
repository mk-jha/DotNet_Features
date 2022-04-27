
using E_ExtendedPropertyPatterns;

var coronaDetails = new CoronaDetails
{
    CoronaVarientInfo = new CoronaVarientInfo { VarientName = "Delta" }
};

Console.WriteLine(VirusDetection.YearOfVirusDetection(coronaDetails));

Console.WriteLine(VirusDetection.YearOfVirusDetectionA(coronaDetails));
