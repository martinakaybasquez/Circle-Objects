using Circle_Objects;
Circle circleShapes;

bool runProgram = true;
while (runProgram)
{
    while (true)
    {
        Console.WriteLine("Please enter a positive number. Number may contain decimals.");
        double userInput = double.Parse(Console.ReadLine());
        circleShapes = new Circle(userInput);
        if (userInput <= 0)
        {
            Console.WriteLine("Invalid entry. Please enter a positive number.\n");
        }
        else
        {
            break;
        }
    }
    Console.WriteLine($"The diameter is {circleShapes.CalculateDiameter()}.\n");
    Console.WriteLine($"The circumference is {circleShapes.CalculateCircumference()}.\n");
    Console.WriteLine($"The area is {circleShapes.CalculateArea()}.\n");
    Console.Write("Would you like the circle to grow?   \n");
    string answer = Console.ReadLine().ToLower();
    if (answer == "y")
    {
        circleShapes.Grow();
        Console.WriteLine($"The diameter is now {circleShapes.CalculateDiameter()}.\n");
        Console.WriteLine($"The circumference is now {circleShapes.CalculateCircumference()}.\n");
        Console.WriteLine($"The area is now {circleShapes.CalculateArea()}.\n");
        break;
    }
    else
    {
        Console.WriteLine("Okie. Byeeeee!");
        runProgram =! true;
    }
}


