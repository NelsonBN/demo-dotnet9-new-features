(string product, int quantity)[] data = [
    ("apple", 5),
    ("banana", 4),
    ("apple", 10),
    ("orange", 25),
    ("banana", 7),
    ("apple", 15),
    ("orange", 2),
    ("banana", 3)];

var aggregated = data.AggregateBy( // `AggregateBy` is new in .NET 9
    entry => entry.product,
    seed: 0,
    (total, curr) => total + curr.quantity);

Console.WriteLine(string.Join(" | ", aggregated));
