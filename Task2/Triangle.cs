using System;

namespace Task2;

public class Triangle
{
    public static double CalcTriangleArea(double basee, double height)
    {
        return 0.5 * basee * height;
    }

    public static double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }
}
