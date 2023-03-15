using ConsoleApp30;
Console.WriteLine("Enter choice");
Console.WriteLine("1. Car");
Console.WriteLine("2. Drob");
string num = Console.ReadLine();
if (num == "1")
{
    CarController controller = new CarController();

    while (true)
    {
        Console.WriteLine("Enter choice:");
        Console.WriteLine("1. Save to file");
        Console.WriteLine("2. Read from file");
        Console.WriteLine("3. Add car");
        Console.WriteLine("4. Show");
        Console.WriteLine("5. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                controller.SaveToFile("car.txt");
                break;
            case "2":
                controller.LoadFromFile("car.txt");
                break;
            case "3":
                controller.AddCar();
                break;
            case "4":
                controller.ShowCars();
                break; 
            case "5":
                return;
            default:
                break;
        }
    }
}
else if (num == "2")
{
    DrobController controller = new DrobController();

    while (true)
    {
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1. Add drob");
        Console.WriteLine("2. Show");
        Console.WriteLine("3. Save to file");
        Console.WriteLine("4. Read from file");
        Console.WriteLine("5. Calculator");
        Console.WriteLine("6. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                controller.AddDrob();
                break;
            case "2":
                controller.ShowDrobs();
                break;
            case "3":
                controller.SaveToFile("drob.txt");
                break;
            case "4":
                controller.LoadFromFile("drob.txt");
                break;
            case "5":
                controller.Calc();
                return;
            default:
                break;
        }
    }
}