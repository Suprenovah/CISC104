using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTests
{
    [Test]
    public void CubeDefaultConstructorTest()
    {
        Cube defaultCube = new Cube();

        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetVolume());
        Assert.AreEqual(0, defaultCube.GetEdgeLength());
    }

    [Test]
    public void CubeTwoByTwoByTwoTest()
    {
        Cube twoByTwoByTwo = new Cube(2f, 2f, 2f);

        // Assert
        Assert.AreEqual(2, twoByTwoByTwo.GetLength());
        Assert.AreEqual(2, twoByTwoByTwo.GetWidth());
        Assert.AreEqual(2, twoByTwoByTwo.GetHeight());
        Assert.AreEqual(8, twoByTwoByTwo.GetVolume());
        Assert.AreEqual(24, twoByTwoByTwo.GetEdgeLength());
    }

    [Test]
    public void CubeSetLengthTest()
    {
        Cube someCube = new Cube(10, 10, 10);

        someCube.SetLength(10);

        Assert.AreEqual(10, someCube.GetLength());

        Assert.AreEqual(10, someCube.GetWidth());
        Assert.AreEqual(10, someCube.GetHeight());
        Assert.AreEqual(1000, someCube.GetVolume());
        Assert.AreEqual(120, someCube.GetEdgeLength());
    }
}
