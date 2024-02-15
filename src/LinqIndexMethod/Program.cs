string[] fruits = [
    "apple",
    "banana",
    "cherry",
    "blueberry",
    "grape",
    "orange"];

// `Index` is new in .NET 9
foreach (var (index, fruit) in fruits.Index())
{
    Console.WriteLine($"{index + 1}º {fruit}");
}
