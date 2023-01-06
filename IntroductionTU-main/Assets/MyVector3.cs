using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyVector3
{
    float _x;
    float _y;
    float _z;

    public float X { get => _x; set => _x = value; }
    public float Y { get => _y; set => _y = value; }
    public float Z { get => _z; set => _z = value; }
    public float SqrMagnitude => _x * _x + _y * _y + _z * _z;
    public float Magnitude => Mathf.Sqrt(_x * _x + _y * _y + _z * _z);
    public MyVector3(float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public void Normalize()
    {
        float norme = Magnitude;
        X /= norme;
        Y /= norme;
        Z /= norme;
    }
    static public MyVector3 operator +(MyVector3 left, MyVector3 right)
    {
        return new MyVector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    }
    static public MyVector3 operator *(MyVector3 left, float i)
    {
        return new MyVector3(left.X*i, left.Y*i, left.Z*i);
    }
}
