using System;

public class Triangle
{
    private float triBase;
    private float height;
    private float side1;
    private float side2;

    public Triangle()
    {
        triBase = 0f;
        height = 0f;
        side1 = 0f;
        side2 = 0f;
    }

    public Triangle(float newBase, float newHeight, float newSide1, float newSide2)
    {
        triBase = newBase;
        height = newHeight;
        side1 = newSide1;
        side2 = newSide2;
    }

    public float GetPerimeter()
    {
        return triBase + side1 + side2;
    }

    public float GetArea()
    {
        return (float)(0.5 * triBase * height);
    }

    public float GetBase()
    {
        return triBase;
    }

    public void SetBase(float newBase)
    {
        triBase = newBase;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetSide1()
    {
        return side1;
    }

    public void SetSide1(float newSide1)
    {
        side1 = newSide1;
    }

    public float GetSide2()
    {
        return side2;
    }

    public void SetSide2(float newSide2)
    {
        side2 = newSide2;
    }
}