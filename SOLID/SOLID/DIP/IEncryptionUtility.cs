namespace DIP;

public interface IEncryptionUtility
{
    string GetEncryptedText(string text);
}

public interface IIdGenerator
{
    string GetId(string text);
}