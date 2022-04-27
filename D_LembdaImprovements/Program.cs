
//Example 1: Already defined return type as "string" and this is also working in C# 10

Func<string> objFunc = () => "Second wave of Covid";
Console.WriteLine(objFunc());

//Example 2: Natural type "var" is working in C# 10

var objFuncA = () => "Third wave of Covid";
Console.WriteLine(objFuncA());

// Example 3: Type casting is working here in C# 10

var objFuncB = string? () => null;
Console.WriteLine(objFuncB());  