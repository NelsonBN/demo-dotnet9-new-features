using System.Security.Cryptography;
using System.Text;

var bytes = Encoding.ASCII.GetBytes("Hello .NET 9!");
var hash = CryptographicOperations.HashData(HashAlgorithmName.SHA512, bytes);
Console.WriteLine($"SHA512: {BitConverter.ToString(hash).Replace("-", "")}");
