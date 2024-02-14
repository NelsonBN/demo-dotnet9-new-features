using System.Text.Json;

var car = new Car { Make = "Lamborghini", Model = "Aventador", FacturedYear = 2020 };
var json = JsonSerializer.Serialize(
    car,
    new JsonSerializerOptions
    {
        WriteIndented = true,
        IndentCharacter = '\t', // `IndentCharacter` is new in .NET 9
        IndentSize = 2 // `IndentSize` is new in .NET 9
    });
Console.WriteLine(json);

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int FacturedYear { get; set; }
}
