using NUnit.Framework;
using System;

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }

        if (a + b > c && a + c > b && b + c > a) {
            return true;
        }
        return false;
    }
}

public class TriangleTests
{
    public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
    {
        Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
    }

}