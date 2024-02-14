var mostFrequentWord = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
    Sed non risus. Suspendisse lectus tortor, dignissim sit amet, 
    adipiscing nec, ultricies sed, dolor. Cras elementum ultrices amet diam.
    """
    .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(word => word.ToLowerInvariant())
    .CountBy(word => word) // `CountBy` is new in .NET 9
    .MaxBy(pair => pair.Value);

Console.WriteLine(mostFrequentWord.Key);


var charFrequence = "Welcome to .NET 9!"
    .ToCharArray()
    .Where(w => !char.IsWhiteSpace(w))
    .CountBy(chars => chars); // `CountBy` is new in .NET 9
Console.WriteLine(string.Join(", ", charFrequence.Select(pair => $"{pair.Key} - {pair.Value}")));