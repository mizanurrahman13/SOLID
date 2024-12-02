namespace SOLID;

public class Membership
{
    public User CreateUser(string name, string password)
    {
        EncryptUtility encryptUtility = new EncryptUtility();
        IdGeneratior generatior = new IdGeneratior();

        User user = new User();
        user.Id = generatior.GenerateId(name);
        user.Name = name;
        user.Password = encryptUtility.EncryptText(password);

        return user;
    }
}
