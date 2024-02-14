using System.Security.Cryptography;

Console.WriteLine($"Kmac128 is Supported algorithms: {Kmac128.IsSupported}");
Console.WriteLine($"Kmac256 is Supported algorithms: {Kmac256.IsSupported}");
Console.WriteLine($"KmacXof128 is Supported algorithms: {KmacXof128.IsSupported}");
Console.WriteLine($"KmacXof256 is Supported algorithms: {KmacXof256.IsSupported}");
