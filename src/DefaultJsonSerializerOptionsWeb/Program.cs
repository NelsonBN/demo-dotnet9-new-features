using System.Text.Json;

var car = new Car { Make = "Lamborghini", Model = "Aventador", FacturedYear = 2020 };
var json = JsonSerializer.Serialize(
    car,
    JsonSerializerOptions.Web); // `JsonSerializerOptions.Web` is new in .NET 9
Console.WriteLine(json);

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int FacturedYear { get; set; }
}
