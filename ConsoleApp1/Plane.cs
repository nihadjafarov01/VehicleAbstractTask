namespace ConsoleApp1;

internal class Plane : Vehicle, IEngine
{
    public int WingLength { get; set; }
    public int HorsePower { get; set; }
    public int TankSize { get; set; }
    public int CurrentOil { get; set; }
    public string FuelType { get; set; }
    public int RemainOilAmount() 
    {
        return (TankSize - CurrentOil);
    }
}
