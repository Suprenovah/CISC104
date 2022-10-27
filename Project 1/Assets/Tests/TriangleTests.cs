using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TriangleTests
{
    [Test]
    public void TriangleDefaultConstructorTest()
    {
        Triangle defaultTriangle = new Triangle();

        Assert.AreEqual(0, defaultTriangle.GetBase());
        Assert.AreEqual(0, defaultTriangle.GetHeight());
        Assert.AreEqual(0, defaultTriangle.GetSide1());
        Assert.AreEqual(0, defaultTriangle.GetSide2());
        Assert.AreEqual(0, defaultTriangle.GetPerimeter());
        Assert.AreEqual(0, defaultTriangle.GetArea());
    }

    [Test]
    public void TriangleArea10Test()
    {
        Triangle area10 = new Triangle(5f, 4f, 0f, 0f);

        Assert.AreEqual(5, area10.GetBase());
        Assert.AreEqual(4, area10.GetHeight());
        Assert.AreEqual(10, area10.GetArea());
    }

    [Test]
    public void TrianglePerimeter6Test()
    {
        Triangle perimeter6 = new Triangle(2f, 0f, 2f, 2f);

        Assert.AreEqual(2, perimeter6.GetBase());
        Assert.AreEqual(2, perimeter6.GetSide1());
        Assert.AreEqual(2, perimeter6.GetSide2());
        Assert.AreEqual(6, perimeter6.GetPerimeter());
    }
}
