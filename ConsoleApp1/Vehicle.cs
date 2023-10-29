namespace ConsoleApp1;

internal abstract class Vehicle
{
    float _driveTime;
    float _drivePath;
    public float DriveTime 
    {
        get => _driveTime;
        set
        {
            if (value > 0) 
            {
                _driveTime = value;
            }
            else
            {
                Console.WriteLine("Musbet eded daxil edin!");
            }
        }
    }
    public float DrivePath
    {
        get => _drivePath;
        set
        {
            if (value > 0)
            {
                _drivePath = value;
            }
            else
            {
                Console.WriteLine("Musbet eded daxil edin!");
            }
        }
    }

    public float AverageSpeed() 
    {
        return DrivePath / DriveTime;
    }

}
