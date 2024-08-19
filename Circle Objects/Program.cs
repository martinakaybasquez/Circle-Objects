using Circle_Objects;
Circle circleShapes;

static bool KeepGoing()
{
    bool userChoice = true;
    while (true)
    {
        Console.WriteLine();
        Console.Write("Would you like to roll again? (y/n)    ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            userChoice = true;
            Console.WriteLine();
            break;
        }
        else if (answer == "n")
        {
            userChoice = !true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid entry. Please choose again.");
        }
    }
    return userChoice;
}


Console.WriteLine("Please enter a positive number. Number may contain decimals.");
circleShapes = new Circle(double.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine($"The diameter is {circleShapes.CalculateDiameter()}.\n");
Console.WriteLine($"The circumference is {circleShapes.CalculateCircumference()}.\n");
Console.WriteLine($"The area is {circleShapes.CalculateArea()}.\n");