using DIP;

namespace SOLID;

public class Membership
{
    private IEncryptionUtility encryptionUtility;
    private IIdGenerator idGeneratior;

    public Membership(IEncryptionUtility encryptionUtility, IIdGenerator idGenerator)
    {
        this.encryptionUtility = encryptionUtility;
        this.idGeneratior = idGenerator;
    }

    public User CreateUser(string name, string password)
    {

        User user = new User();
        user.Id = idGeneratior.GetId(name);
        user.Name = name;
        user.Password = encryptionUtility.GetEncryptedText(password);

        return user;
    }
}
