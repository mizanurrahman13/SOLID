using DIP;

namespace SOLID;

public class IdGeneratior: IIdGenerator
{
    public string GenerateId(string userName)
    {
        Random random = new Random(DateTime.Now.Microsecond);

        return char.ToUpper(userName[0]).ToString() + random.Next();
    }

    public string GetId(string text)
    {
        return GenerateId(text);
    }
}
