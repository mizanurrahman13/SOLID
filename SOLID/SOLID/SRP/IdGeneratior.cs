namespace SOLID;

public class IdGeneratior
{
    public string GenerateId(string userName)
    {
        Random random = new Random(DateTime.Now.Microsecond);

        return char.ToUpper(userName[0]).ToString() + random.Next();
    }
}
