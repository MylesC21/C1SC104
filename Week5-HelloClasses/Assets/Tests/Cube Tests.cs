using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

public class CubeTests
{
    //Test the default constuctor
    [Test]
    public void CubeDefaultConstructorTest()
    {
        //Setup and Act
        Cube defaultCube = new Cube();

        //Assert
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetVolume());
        Assert.AreEqual(0, defaultCube.GetEdge());

    }

    //Test a 2 x 2 x 4 Cube
    [Test]
    public void RectangleTwoByFourTest()
    {
        //Setup and Act
        Cube twoBytwoByfour = new Cube(2f, 2f, 4f);

        //Assert
        Assert.AreEqual(2, twoBytwoByfour.GetHeight());
        Assert.AreEqual(2, twoBytwoByfour.GetWidth());
        Assert.AreEqual(2, twoBytwoByfour.GetLength());
        Assert.AreEqual(2, twoBytwoByfour.GetVolume());
        Assert.AreEqual(2, twoBytwoByfour.GetEdge());
    }

    //Test a 10 x 10 Rectangle
    [Test]
    public void CubeNineByNineTenTest()
    {
        Cube nineBynineByTen = new Cube(9f, 9f, 10f);
        //Assert
        Assert.AreEqual(9, nineBynineByTen.GetHeight());
        Assert.AreEqual(9, nineBynineByTen.GetWidth());
        Assert.AreEqual(10, nineBynineByTen.GetLength());
        Assert.AreEqual(810, nineBynineByTen.GetVolume());
        Assert.AreEqual(10, nineBynineByTen.GetEdge());
    }

    //Test the SetHeight method
    [Test]

    public void CubeSetHeightTest()
    {
        //Setup
        Cube someCube = new Cube(5, 5, 7);

        //Act
        someCube.SetHeight(5);

        //Assert
        Assert.AreNotEqual(1, someCube.GetHeight());
        Assert.AreEqual(5, someCube.GetHeight());

        Assert.AreEqual(5, someCube.GetWidth());
        Assert.AreEqual(7, someCube.GetLength());
        Assert.AreEqual(175, someCube.GetVolume());
        Assert.AreEqual(7, someCube.GetEdge());
    }
}