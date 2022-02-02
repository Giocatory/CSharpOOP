using LessonSix;

Miniwan myCar = new(120, "Nyaha", "Grey");

Console.WriteLine($"Name: {myCar.Name}; " +
    $"Color: {myCar.Color}; " +
    $"Max speed: {myCar.MaxSpeed}; " +
    $"Current speed: {myCar.CurrSpeed = 1}");

Miniwan mySecondCar = new(200, "Toyotka", "White");

Console.WriteLine($"Name: {mySecondCar.Name}; " +
    $"Color: {mySecondCar.Color}; " +
    $"Max speed: {mySecondCar.MaxSpeed}; " +
    $"Current speed: {mySecondCar.CurrSpeed = 5}");

Console.WriteLine($"Cars created: {Car.HowManyCarsCreated}");