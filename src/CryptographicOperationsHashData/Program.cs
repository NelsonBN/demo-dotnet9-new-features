using System.Security.Cryptography;
using System.Text;

var bytes = Encoding.ASCII.GetBytes("Hello .NET 9!");
var hash = CryptographicOperations.HashData(HashAlgorithmName.SHA512, bytes); // `CryptographicOperations.HashData` is new in .NET 9
Console.WriteLine($"SHA512: {BitConverter.ToString(hash).Replace("-", "")}");
