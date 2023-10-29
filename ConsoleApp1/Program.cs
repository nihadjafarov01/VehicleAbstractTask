using Microsoft.VisualBasic.FileIO;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[0];
        Console.WriteLine("1 - Yeni car yarat \n2 - Yeni Bicycle yarat\n3 - Yeni Plane yarat\n4 - Bütün vehiclelara bax\n5 - Vehicle-ı sil \nq. quit");
        char option;
        char option2;
        char option3;
        char option4;
        do
        {
            Console.WriteLine("1, 2, 3, 4, 5 or q");
            option = Convert.ToChar(Console.ReadLine());
            switch (option) 
            {
                case '1':
                    Console.Write("Door count: ");
                    int doorCount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Win code: ");
                    int winCode = Convert.ToInt32(Console.ReadLine());
                    Vehicle car = new Car(doorCount, winCode);
                    Console.WriteLine("1. Drive time and Drive path \n2. Horse power \n3. Tank size \n4. Current oil \n5. Fuel type \n6. Remain oil amount \n7. Wheel thickness \n8. Transmission kind \nq. quit");
                    do 
                    {
                        Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8 or q");
                        option2 = Convert.ToChar(Console.ReadLine());
                        switch (option2)
                        {
                            case '1':
                                Console.Write("Drive time (in hour): ");
                                float driveTime = Convert.ToInt32(Console.ReadLine());
                                car.DriveTime = driveTime;
                                Console.Write("Drive path (in km): ");
                                float drivePath = Convert.ToInt32(Console.ReadLine());
                                car.DrivePath = drivePath;
                                break;
                            case '2':
                                //HorsePower
                                Console.Write("Horse power: ");
                                int horsePower = Convert.ToInt32(Console.ReadLine());
                                ((Car)car).HorsePower = horsePower;
                                break;
                            case '3':
                                //TankSize
                                Console.Write("Tank size: ");
                                int tankSize = Convert.ToInt32(Console.ReadLine());
                                ((Car)car).TankSize = tankSize;                                
                                break;
                            case '4':
                                //CurrentOil
                                Console.Write("Current oil: ");
                                int currentOil = Convert.ToInt32(Console.ReadLine());
                                ((Car)car).CurrentOil = currentOil;
                                break;
                            case '5':
                                //FuelType
                                Console.Write("Fuel type: ");
                                string fuelType = Console.ReadLine();
                                ((Car)car).FuelType = fuelType;
                                break;
                            case '6':
                                //RemainOilAmount
                                break;
                            case '7':
                                //WheelThickness
                                Console.Write("Wheel thickness: ");
                                int wheelThickness = Convert.ToInt32(Console.ReadLine());
                                ((Car)car).WheelThickness = wheelThickness;
                                break;
                            case '8':
                                //TransmissionKind
                                Console.Write("Transmission kind: ");
                                string transmissionKind = Console.ReadLine();
                                ((Car)car).TransmissionKind = transmissionKind;
                                break;
                        }
                    }
                    while (option2 != 'q');

                    Array.Resize(ref vehicles,vehicles.Length+1);
                    vehicles[vehicles.Length-1] = car;
                    break;
                case '2':
                    Console.WriteLine("Pedal kind: ");
                    string pedalKind = Console.ReadLine();
                    Bicycle bicycle = new Bicycle();
                    bicycle.PedalKind = pedalKind;
                    option3 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("1. Drive time and Drive path \n2. Whell thickness \nq. quit");
                    do
                    {
                        Console.WriteLine("1, 2 or q");
                        option3 = Convert.ToChar(Console.ReadLine());
                        switch (option3)
                        {
                            case '1':
                                Console.Write("Drive time: ");
                                float driveTime = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Drive path: ");
                                float drivePath = Convert.ToInt32(Console.ReadLine());
                                bicycle.DriveTime = driveTime;
                                bicycle.DrivePath = drivePath;
                                break;
                            case '2':
                                //WhellThickness
                                Console.Write("Whell thickness: ");
                                int whellThickness = Convert.ToInt32(Console.ReadLine());
                                ((Bicycle)bicycle).WheelThickness = whellThickness;
                                break;
                        }
                    }
                    while (option3 != 'q');
                    Array.Resize(ref vehicles, vehicles.Length + 1);
                    vehicles[vehicles.Length - 1] = bicycle;
                    break;
                case '3':
                    Console.WriteLine("Wing length: ");
                    int wingLength = Convert.ToInt32(Console.ReadLine());
                    Plane plane = new Plane();
                    plane.WingLength = wingLength;
                    Console.WriteLine("1. Drive time and Drive path \n2. Horse power \n3. Tank size \n4. Current oil \n5. Fuel type \n6. Remain oil amount \n q. quit");
                    do
                    {
                        Console.WriteLine("1, 2, 3, 4, 5, 6 or q");
                        option4 = Convert.ToChar(Console.ReadLine());
                        switch (option4)
                        {
                            case '1':
                                Console.Write("Drive time: ");
                                float driveTime = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Drive path: ");
                                float drivePath = Convert.ToInt32(Console.ReadLine());
                                plane.DriveTime = driveTime;
                                plane.DrivePath = drivePath;
                                break;
                            case '2':
                                //HorsePower
                                Console.Write("Horse power: ");
                                int horsePower = Convert.ToInt32(Console.ReadLine());
                                ((Plane)plane).HorsePower = horsePower;
                                break;
                            case '3':
                                //TankSize
                                Console.Write("Tank size: ");
                                int tankSize = Convert.ToInt32(Console.ReadLine());
                                ((Plane)plane).TankSize = tankSize;
                                break;
                            case '4':
                                //CurrentOil
                                Console.Write("Current oil: ");
                                int currentOil = Convert.ToInt32(Console.ReadLine());
                                ((Plane)plane).CurrentOil = currentOil;
                                break;
                            case '5':
                                //FuelType
                                Console.Write("Fuel type: ");
                                string fuelType = Console.ReadLine();
                                ((Plane)plane).FuelType = fuelType;
                                break;
                        }
                    }
                    while (option4 != 'q');
                    Array.Resize(ref vehicles, vehicles.Length + 1);
                    vehicles[vehicles.Length - 1] = plane;
                        break;
                case '4':
                    foreach (var item in vehicles)
                    {
                        if (item is Car)
                        {
                            Console.WriteLine("Car: ");
                            Console.WriteLine("   Door count: " + ((Car)item).DoorCount);
                            Console.WriteLine("   Win code: " + ((Car)item).WinCode);
                            if (item.DriveTime != 0 && item.DrivePath != 0)
                            {
                                Console.WriteLine("   Drive time: " + ((Car)item).DriveTime + "km");
                                Console.WriteLine("   Drive path: " + ((Car)item).DrivePath + "hour");
                                Console.WriteLine("   Average speed: " + ((Car)item).AverageSpeed() + "km/hour");
                            }
                            if (((Car)item).TankSize != 0)
                            {
                                Console.WriteLine("   Tank size: " + ((Car)item).TankSize);
                            }
                            if (((Car)item).CurrentOil != 0)
                            {
                                Console.WriteLine("   Current oil: " + ((Car)item).CurrentOil);
                            }
                            if (!String.IsNullOrEmpty(((Car)item).FuelType))
                            {
                                Console.WriteLine("   Fuel type: " + ((Car)item).FuelType);
                            }
                            if (((Car)item).WheelThickness != 0)
                            {
                                Console.WriteLine("   Wheel thickness: " + ((Car)item).WheelThickness);
                            }
                            if (!String.IsNullOrEmpty(((Car)item).TransmissionKind))
                            {
                                Console.WriteLine("   Transmission kind: " + ((Car)item).TransmissionKind);
                            }
                            if ((((Car)item).TankSize) != 0 && (((Car)item).CurrentOil) != 0)
                            {
                                Console.WriteLine("   Remain oil amount: " + ((Car)item).RemainOilAmount());
                            }
                        }
                        if (item is Bicycle)
                        {
                            Console.WriteLine("Bicycle: ");
                            Console.WriteLine("   Pedal kind: " + ((Bicycle)item).PedalKind);
                            if (item.DriveTime != 0 && item.DrivePath != 0)
                            {
                                Console.WriteLine("   Drive time: " + ((Bicycle)item).DriveTime + "km");
                                Console.WriteLine("   Drive path: " + ((Bicycle)item).DrivePath + "hour");
                                Console.WriteLine("   Average speed: " + ((Bicycle)item).AverageSpeed() + "km/hour");
                            }
                            if (((Bicycle)item).WheelThickness != 0)
                            {
                                Console.WriteLine("   Wheel thickness: " + ((Bicycle)item).WheelThickness);
                            }
                        }
                        if (item is Plane)
                        {
                            Console.WriteLine("Plane: ");
                            Console.WriteLine("   Wing length: " + ((Plane)item).WingLength);
                            if (item.DriveTime != 0 && item.DrivePath != 0)
                            {
                                Console.WriteLine("   Drive time: " + ((Plane)item).DriveTime + "km");
                                Console.WriteLine("   Drive path: " + ((Plane)item).DrivePath + "hour");
                                Console.WriteLine("   Average speed: " + ((Plane)item).AverageSpeed() + "km/hour");
                            }
                            if (((Plane)item).TankSize != 0)
                            {
                                Console.WriteLine("   Tank size: " + ((Plane)item).TankSize);
                            }
                            if (((Plane)item).CurrentOil != 0)
                            {
                                Console.WriteLine("   Current oil: " + ((Plane)item).CurrentOil);
                            }
                            if (!String.IsNullOrEmpty(((Plane)item).FuelType))
                            {
                                Console.WriteLine("   Fuel type: " + ((Plane)item).FuelType);
                            }
                            if ((((Plane)item).TankSize) != 0 && (((Plane)item).CurrentOil) != 0)
                            {
                                Console.WriteLine("   Remain oil amount: " + ((Plane)item).RemainOilAmount());
                            }
                        }
                    }
                    break;
                case '5':
                    Console.Write("Index of vehicle: ");
                    int indexOfVehicle = Convert.ToInt32(Console.ReadLine());
                    Vehicle[] newVehicles = new Vehicle[vehicles.Length-1];
                    int j = 0;
                    for (int i = 0;  i < vehicles.Length;  i++)
                    {
                        if (i != indexOfVehicle)
                        {
                            newVehicles[j] = vehicles[i];
                            vehicles[j] = newVehicles[j];
                            j++;
                        }
                    }
                    Array.Resize(ref vehicles, j);
                    break;
            }
        }
        while (option != 'q');
    }
}