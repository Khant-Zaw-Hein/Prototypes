// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");
//EncryptHash();
HashSHA();

static void EncryptHash()
{
    using (Aes aesAlgorithm = Aes.Create())
    {
        aesAlgorithm.KeySize = 256;
        aesAlgorithm.GenerateKey();
        string keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
        string keySalt64 = Convert.ToBase64String(aesAlgorithm.IV);
    }
}

static void HashSHA()
{
    string input = "pass1234";
    byte[] bytes = Encoding.UTF8.GetBytes(input);

    SHA256Managed hashAlgorithm = new SHA256Managed();
    byte[] hash = hashAlgorithm.ComputeHash(bytes);

    string hashedInput = Convert.ToBase64String(hash);
    Console.WriteLine(hashedInput);
}
