using System;

public class Rectangle
{
    private float height;
    private float width;
    private float length;

    public Rectangle()
    {
        height = 0f;
        width = 0f;
        length = 0f;
    }

    public Rectangle(float newHeight, float newWidth)
    {

        height = newHeight;
        width = newWidth;
    }

    public float GetPerimeter()
    {
        return 2 * height + 2 * width;
    }

    public float GetArea()
    {
        return height * width;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }
    public float GetLength()
    {
        return Length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;