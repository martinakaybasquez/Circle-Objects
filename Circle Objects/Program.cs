using Circle_Objects;
Circle circleShapes;

Console.WriteLine("Please enter a positive number. Number may contain decimals.");
circleShapes = new Circle(double.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine($"The diameter is {circleShapes.CalculateDiameter()}.\n");
Console.WriteLine($"The circumference is {circleShapes.CalculateCircumference()}.\n");
Console.WriteLine($"The area is {circleShapes.CalculateArea()}.\n");

circleShapes.Grow();
Console.WriteLine($"The diameter is now {circleShapes.CalculateDiameter()}.\n");
Console.WriteLine($"The circumference is now {circleShapes.CalculateCircumference()}.\n");
Console.WriteLine($"The area is now {circleShapes.CalculateArea()}.\n");