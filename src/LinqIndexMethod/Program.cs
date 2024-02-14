string[] fruits = [
    "apple",
    "banana",
    "cherry",
    "blueberry",
    "grape",
    "orange"];

foreach (var (index, fruit) in fruits.Index())  // `Index` is new in .NET 9
{
    Console.WriteLine($"{index + 1}º {fruit}");
}
