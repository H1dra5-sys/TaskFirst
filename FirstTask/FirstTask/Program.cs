using System;
class Program {
    double theEdgeOfTheCube, theRadiusOfTheSphere, vSphere, vCube;
    double pi, wastePercentage;

     Program() {
        Console.Write("Please, input the edge of the cube: ");
        theEdgeOfTheCube = double.Parse(Console.ReadLine());

        Console.Write("Please, input the radius of the sphere <= edge of the cube / 2: ");
        theRadiusOfTheSphere = double.Parse(Console.ReadLine());
        
        pi = Math.PI;

        vSphere = (4 * pi * (theRadiusOfTheSphere * theRadiusOfTheSphere * theRadiusOfTheSphere) / 3);
        Console.Write($"The volume of a sphere = {vSphere}");
        Console.WriteLine();

        vCube = theEdgeOfTheCube * theEdgeOfTheCube * theEdgeOfTheCube;
        Console.Write($"The volume of a Cube = {vCube}");
        Console.WriteLine();

        wastePercentage = (vCube - vSphere) / vCube * 100;
        Console.Write($"Waste Percentage = {wastePercentage}");
    }

    static void Main(string[] args) {
        Program solve = new Program();
    }
}
