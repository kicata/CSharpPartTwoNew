using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


class SurfaceOfTriangle
{
    public static double surface;
    static void Main()
    {
        Console.WriteLine("Please choose how to calculate the surface of triangle:");
        Console.WriteLine("Side and altidude to it -> enter 1");
        Console.WriteLine("Three sides -> enter 2");
        Console.WriteLine("Two sides and an angle between them -> enter 3");
        Console.Write("Enter value ");
        int variant = int.Parse(Console.ReadLine());
        switch (variant)
        {
            case 1: SideAndAltitudeSurface(); break;
            case 2: TreeSidesSurface(); break;
            case 3: TwoSidesAndAngleBetweenSurface(); break;
            default: Console.WriteLine("WTF!-> try again");
                break;
        }
    }
    static void SideAndAltitudeSurface()
    {
        Console.Write("Enter side = ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude h = ");
        double h = double.Parse(Console.ReadLine());
        surface = 0.5 * (side * h);
        Console.WriteLine("The surface of triangle is {0}", surface);
    }
    static void TreeSidesSurface()
    {
        Console.Write("Enter side a = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side b = ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter side c = ");
        double sideC = double.Parse(Console.ReadLine());


        double s = (sideA + sideB + sideC) * 0.5;
        surface = Math.Sqrt(s * ((s - sideA) * (s - sideB) * (s - sideC)));

        Console.WriteLine("The surface of triangle is {0}", surface);
    }
    static void TwoSidesAndAngleBetweenSurface()
    {
        Console.Write("Enter side a = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side b = ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Size of the angle in degrees:");
        int angle = int.Parse(Console.ReadLine());

        double angleInRadians = Math.PI * angle / 180.0;
        surface = 0.5 * sideA * sideB * Math.Sin(angleInRadians);
        Console.WriteLine("The surface of triangle is {0}", surface);

    }
}

