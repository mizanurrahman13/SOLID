namespace ISP;

public interface IComputer
{
    void TurnOnMonitor();
    void TurnOnCPU();
    //void AttatchUSB();
    //void AttatchPrinter();
    //void AttatchHDMI();
    //void AttatchPowerCable();
}

public interface IOutPutGenerator
{
    void AttatchPrinter();
    void AttatchHDMI();
}

public interface IPowerSupply
{
    void AttatchPowerCable();
}

public interface IUSBConnectable
{
    void AttatchUSB();
}
