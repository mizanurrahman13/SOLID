using DIP;
using System.Security.Cryptography;

namespace SOLID;

public class EncryptUtility: IEncryptionUtility
{
    public string EncryptText(string plainText)
    {
        return MD5.Create(plainText).ToString();
    }

    public string GetEncryptedText(string text)
    {
        return EncryptText(text);
    }
}
