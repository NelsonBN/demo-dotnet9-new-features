using System.Security.Cryptography;

Console.WriteLine($"Kmac128 is Supported algorithms: {Kmac128.IsSupported}"); // `Kmac128` is new in .NET 9
Console.WriteLine($"Kmac256 is Supported algorithms: {Kmac256.IsSupported}"); // `Kmac256` is new in .NET 9
Console.WriteLine($"KmacXof128 is Supported algorithms: {KmacXof128.IsSupported}"); // `KmacXof128 is new in .NET 9
Console.WriteLine($"KmacXof256 is Supported algorithms: {KmacXof256.IsSupported}"); // `KmacXof256 is new in .NET 9
