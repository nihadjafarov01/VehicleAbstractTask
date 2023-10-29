namespace ConsoleApp1;

internal class Bicycle : Vehicle, IWheel
{
    int _wheelThickness;
    public string PedalKind { get; set; }
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

}
