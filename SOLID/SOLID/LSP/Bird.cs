namespace LSP;

public abstract class Bird
{
    public abstract void Fly();
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        // Implementation for sparrow flying
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Ostriches can't fly");
    }
}

