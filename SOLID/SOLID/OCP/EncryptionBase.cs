namespace OCP;

public abstract class EncryptionBase
{
    protected string encryptionKey;

    public abstract object Encrypt(object obj);
}
