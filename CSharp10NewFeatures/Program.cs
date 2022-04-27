//using System.Text.Json;

var studentsName = new[] { "Pawan", "Diwakar", "Shilpa", "Divya" };

var serialize = JsonSerializer.Serialize(studentsName);

Console.WriteLine(serialize);