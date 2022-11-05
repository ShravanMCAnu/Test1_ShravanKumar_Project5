// See https://aka.ms/new-console-template for more information
using Test1_ShravanKumar_Project5;

PerimeterOfCircle objPerimeterOfCircle=new PerimeterOfCircle();
Console.WriteLine("For Area Of Circle say 'A' or For For Perimeter of Circle say 'P'");

string? choice = Console.ReadLine();
switch (choice)
{
    case "A" or "a":
        Console.WriteLine("Enter Radius: ");
        double aRadius = Convert.ToDouble(Console.ReadLine());
        objPerimeterOfCircle.CalculateArea(aRadius);
        break;
    case "P" or "p":
        Console.WriteLine("Enter Radius: ");
        double pRadius = Convert.ToDouble(Console.ReadLine());
        objPerimeterOfCircle.CalculatePerimeter(pRadius);
        break;
}



