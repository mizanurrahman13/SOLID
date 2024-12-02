using System.Security.Cryptography;

namespace SOLID;

public class EncryptUtility
{
    public string EncryptText(string plainText)
    {
        return MD5.Create(plainText).ToString();
    }
}
