namespace ConsoleApp1;

internal class Car : Vehicle, IEngine, IWheel, ITransmission
{
    int _wheelThickness;
    public int DoorCount { get; set; }
    public int WinCode { get; set; }
    public int HorsePower { get; set; }
    public int TankSize { get; set; }
    public int CurrentOil { get; set; }
    public string FuelType { get; set; }
    public int RemainOilAmount()
    {
        return (TankSize - CurrentOil);
    }
    public int WheelThickness
    {
        get => _wheelThickness;
        set
        {
            if (value > 0)
            {
                _wheelThickness = value;
            }
            else
            {
                Console.WriteLine("Musbet eded daxil edin!");
            }
        }
    }
    public string TransmissionKind { get; set; }

    public Car(int doorCount, int winCode)
    {
        DoorCount = doorCount;
        WinCode = winCode;
    }
}
